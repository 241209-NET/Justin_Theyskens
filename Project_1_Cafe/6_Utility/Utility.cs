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

    public static string AddSpaces(string str)
    {
        string output = "";
        for(int i = 0; i < str.Length; i++)
        {
            if (i > 0 && Char.IsUpper(str[i]))
                output += " " + str[i];
            else
                output += str[i];
        }

        return output;
    }
}