using Cafe.API.Items;

namespace Cafe.API.Util;

public static class Utility
{
    private static int _ItemIndex;

    public static int SetItemId(Item item)
    {
        _ItemIndex ++;
        item.ItemId = _ItemIndex;

        return item.ItemId;
    }
}