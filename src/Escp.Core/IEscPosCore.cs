using Escp.Core.Core;

namespace Escp.Core
{
    public interface IEscPosCore
    {
        IEscPosCore Init();

        
        IEscPosCore Align(byte position);

        IEscPosCore Align(Alignment position);

        
        IEscPosCore FontSize(byte size);

        IEscPosCore SetFontSize(FontSize size);

        IEscPosCore ResetFontSize();

        
        IEscPosCore Bold(bool isBold);

        IEscPosCore SetBold();

        IEscPosCore UnsetBold();

        
        IEscPosCore Underline(bool isUnderlined);

        IEscPosCore SetUnderline();

        IEscPosCore UnsetUnderline();

        
        IEscPosCore FontScale(byte scale);

        IEscPosCore SetFontScale(ScaleMode scale);

        IEscPosCore ResetFontScale();

        
        IEscPosCore LineFeed(int lineNum = 1);

        IEscPosCore PrintText(string text);

        IEscPosCore FeedAndCut();

    }
}