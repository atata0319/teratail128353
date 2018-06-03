using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ExtendedCheckBox
{
    /// <summary>
    /// 無効時に文字色を白にするチェックボックス
    /// </summary>
    /// <remarks>
    /// WM_ENABLE メッセージを無視することにより、再描画の発生を抑えて文字色を維持します。
    /// 通常の Enabled プロパティを変更する方法では .NET の内部状態が更新されてしまうため、
    /// EnableWindow によって直接コントロールのスタイルを変更します。
    /// </remarks>
    class ExtendedCheckBox3 : CheckBox
    {
        const int WM_ENABLE = 0x000A;

        [DllImport("USER32", CharSet = CharSet.None)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private extern static bool EnableWindow(IntPtr hWnd, [MarshalAs(UnmanagedType.Bool)] bool enabled);

        bool enable = true;

        [Browsable(true)]
        [Description("コントロールの有効/無効を切り替えます。")]
        [Category("動作")]
        public bool Enabled2
        {
            get
            {
                return enable;
            }
            set
            {
                enable = value;
                if (enable)
                {
                    ForeColor = Color.Black;
                }
                else
                {
                    ForeColor = Color.White;
                }
                if (IsHandleCreated)
                {
                    EnableWindow(Handle, enable);
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_ENABLE && m.WParam == IntPtr.Zero)
            {
                // WM_ENABLE を WndProc に渡さないことにより色を変更させない。
                m.LParam = IntPtr.Zero;
            }
            else
            {
                base.WndProc(ref m);
            }
        }
    }
}
