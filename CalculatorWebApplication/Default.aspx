﻿<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculatorWebApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
    <link href="/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="calculator-holder">
            <table class="calculator" id="calc">
                <tr>
                    <td colspan="4" class="calc_td_result">
                        <input type="text" readonly="readonly" runat="server" name="calc_result" id="calc_result" class="calc_result" />
                    </td>
                </tr>
                <tr>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button7" runat="server" CssClass="calc_btn" Text="7" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button8" runat="server" CssClass="calc_btn" Text="8" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button9" runat="server" CssClass="calc_btn" Text="9" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="ButtonMinus" runat="server" CssClass="calc_op" Text="-" OnClick="ButtonMinus_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button4" runat="server" CssClass="calc_btn" Text="4" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button5" runat="server" CssClass="calc_btn" Text="5" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button6" runat="server" CssClass="calc_btn" Text="6" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="ButtonMultiply" runat="server" CssClass="calc_op" Text="x" OnClick="ButtonMultiply_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button1" runat="server" CssClass="calc_btn" Text="1" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button2" runat="server" CssClass="calc_btn" Text="2" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button3" runat="server" CssClass="calc_btn" Text="3" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="ButtonDivide" runat="server" CssClass="calc_op" Text="&divide;" OnClick="ButtonDivide_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="calc_td_btn">
                        <asp:Button ID="ButtonCE" runat="server" CssClass="calc_ce" Text="CE" OnClick="ButtonCE_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="Button0" runat="server" CssClass="calc_btn" Text="0" OnClick="NumButton_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="ButtonEqual" runat="server" CssClass="calc_eq" Text="=" OnClick="ButtonEquals_Click"/>
                    </td>
                    <td class="calc_td_btn">
                        <asp:Button ID="ButtonPlus" runat="server" CssClass="calc_op" Text="+" OnClick="ButtonPlus_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
