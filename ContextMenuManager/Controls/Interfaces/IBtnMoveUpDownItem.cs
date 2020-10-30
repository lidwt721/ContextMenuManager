﻿using BulePointLilac.Controls;

namespace ContextMenuManager.Controls
{
    interface IBtnMoveUpDownItem
    {
        MoveButton BtnMoveUp { get; set; }
        MoveButton BtnMoveDown { get; set; }
    }

    sealed class MoveButton : PictureButton
    {
        public MoveButton(IBtnMoveUpDownItem item, bool isUp) : base(isUp ? AppImage.Up : AppImage.Down)
        {
            ((MyListItem)item).AddCtr(this);
            ((MyListItem)item).SetCtrIndex(this, isUp ? 2 : 1);
        }
    }
}