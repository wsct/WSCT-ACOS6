using Microsoft.AspNetCore.Components;
using WSCT.ACOS6.Security.TripleDes;
using WSCT.Helpers;
using WSCT.Layers.ACOS6;

namespace WSCT.GUI.Plugins.ACOS6;

public partial class Acos6Gui
{
    private string _cardKeyText = "11 22 33 44 55 66 77 88 99 AA BB CC DD EE FF 00";
    private string _cardChallengeText = "11 22 33 44";
    private string _shortKeyAuthenticationValue = string.Empty;

    private bool IsValidCardKey => TryParseHex(_cardKeyText, 16, out _);
    private bool IsValidCardChallenge => TryParseHex(_cardChallengeText, 4, out _);
    private bool CanCompute => IsValidCardKey && IsValidCardChallenge;

    private void OnCC4ManagerChanged(ChangeEventArgs e)
    {
        if (e.Value is bool isChecked)
        {
            ACOS6Controller.UseCC4Manager = isChecked;
        }
    }

    private void ComputeShortKeyResult()
    {
        if (!TryParseHex(_cardKeyText, 16, out var shortKey) ||
            !TryParseHex(_cardChallengeText, 4, out var challenge))
        {
            return;
        }

        _shortKeyAuthenticationValue = challenge.Create3DESShortAuthenticationData(shortKey).ToHexa(' ');
    }

    private static bool TryParseHex(string? text, int expectedLength, out byte[] bytes)
    {
        bytes = [];
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }

        try
        {
            bytes = text.FromHexa();
            return bytes.Length == expectedLength;
        }
        catch
        {
            return false;
        }
    }

    public void Dispose()
    {
    }
}