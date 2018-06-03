using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ExtendedCheckBox
{
    /// <summary>
    /// 無効時に文字色を白にするチェックボックス
    /// </summary>
    /// <remarks>
    /// WM_PAINT を無視することにより DWM によって既定の描画が実行されることを利用しています。
    /// Windows 7 以前では正しく動作しないと思われます。
    /// マウスをコントロールに重ねたまま、Enabled2 プロパティを変更すると正しく描画されません。
    /// </remarks>
    class ExtendedCheckBox2 : CheckBox
    {
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
                if (value)
                {
                    this.AutoCheck = true;
                    this.ForeColor = Color.Black;
                    this.TabStop = true;
                }
                else
                {
                    this.AutoCheck = false;
                    this.ForeColor = Color.White;
                    this.TabStop = false;
                }
                Refresh();
                // 上の Refresh で WM_PAINT が呼び出されて、
                // 無効時の描画が実行されるため、enable を変化させるのはこのタイミングになります。
                enable = value;
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_KEYFIRST = 0x0100;
            const int WM_KEYLAST = 0x010F;
            const int WM_MOUSEFIRST = 0x0200;
            const int WM_MOUSELAST = 0x020E;
            const int WM_PAINT = 0x000F;
            // 無効時には WM_PAINT 以外にマウスとキーボード関連のメッセージも処理しません。
            if (enable || !((m.Msg >= WM_KEYFIRST && m.Msg <= WM_KEYLAST) || (m.Msg >= WM_MOUSEFIRST && m.Msg <= WM_MOUSELAST) || m.Msg == WM_PAINT))
            {
                base.WndProc(ref m);
            }
        }
    }
}
