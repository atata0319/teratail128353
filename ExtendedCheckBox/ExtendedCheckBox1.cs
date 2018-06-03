using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ExtendedCheckBox
{
    /// <summary>
    /// 無効時に文字色を白にするチェックボックス
    /// </summary>
    /// <remarks>
    /// 独自レンダリングによって実現する方法です。
    /// 文字位置のずれを気にしなければ、Windows API に頼らなくて済みます。
    /// </remarks>
    class ExtendedCheckBox1 : CheckBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Enabled)
            {
                base.OnPaint(e);
            }
            else
            {
                if (UseCompatibleTextRendering)
                {
                    // 背景色を無効で描画
                    ControlPaint.DrawButton(
                        e.Graphics,
                        ClientRectangle,
                        ButtonState.Inactive);
                    // テキストを白で描画
                    using (StringFormat sf = new StringFormat())
                    {
                        e.Graphics.DrawString(
                            Text,
                            Font,
                            Brushes.White,
                            ClientRectangle,
                            sf);
                    }
                }
                else
                {
                    // 背景色を無効で描画
                    ButtonRenderer.DrawParentBackground(
                        e.Graphics,
                        ClientRectangle,
                        this);
                    ButtonRenderer.DrawButton(
                        e.Graphics,
                        ClientRectangle,
                        Checked ? PushButtonState.Pressed : PushButtonState.Disabled);
                    // テキストを白で描画
                    // チェックボックスの場合、文字列を出力する位置が右にずれますが、
                    // 補正処理は実施していません。
                    TextRenderer.DrawText(
                        e.Graphics,
                        Text,
                        Font,
                        ClientRectangle,
                        Color.White,
                        TextFormatFlags.SingleLine | TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
                }
            }
        }
    }
}
