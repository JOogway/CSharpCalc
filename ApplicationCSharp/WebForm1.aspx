<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ApplicationCSharp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 297px; width: 254px">
    <form id="form1" runat="server">
    <div style="height: 371px; width: 274px">
    
        <asp:TextBox ID="numberdisplay" runat="server" Height="34px" style="margin-top: 0px" Width="247px"></asp:TextBox>
        <br />
        <asp:Button ID="sevenbutton" runat="server" Height="64px" OnClick="sevenbutton_Click" Text="7" Width="64px" />
        <asp:Button ID="eightbutton" runat="server" Height="64px" OnClick="eightbutton_Click" Text="8" Width="64px" />
        <asp:Button ID="ninebutton" runat="server" Height="64px" OnClick="ninebutton_Click" Text="9" Width="64px" />
        <asp:Button ID="dividebutton" runat="server" Height="64px" OnClick="dividebutton_Click" Text="/" Width="64px" />
        <br />
        <asp:Button ID="fourbutton" runat="server" Height="64px" OnClick="fourbutton_Click" Text="4" Width="64px" />
        <asp:Button ID="fivebutton" runat="server" Height="64px" OnClick="fivebutton_Click" Text="5" Width="64px" />
        <asp:Button ID="sixbutton" runat="server" Height="64px" OnClick="sixbutton_Click" Text="6" Width="64px" />
        <asp:Button ID="crossbutton" runat="server" Height="64px" OnClick="crossbutton_Click" Text="x" Width="64px" />
        <br />
        <asp:Button ID="onebutton" runat="server" Height="64px" OnClick="onebutton_Click" Text="1" Width="64px" />
        <asp:Button ID="twobutton" runat="server" Height="64px" OnClick="twobutton_Click" Text="2" Width="64px" />
        <asp:Button ID="threebutton" runat="server" Height="64px" OnClick="threebutton_Click" Text="3" Width="64px" />
        <asp:Button ID="minusbutton" runat="server" Height="64px" OnClick="minusbutton_Click" Text="-" Width="64px" />
        <br />
        <asp:Button ID="zerobutton" runat="server" Height="64px" OnClick="zerobutton_Click" Text="0" Width="64px" />
        <asp:Button ID="dotbutton" runat="server" Height="64px" OnClick="dotbutton_Click" Text="." Width="64px" />
        <asp:Button ID="equalsbutton" runat="server" Height="64px" OnClick="equalsbutton_Click" Text="=" Width="64px" />
        <asp:Button ID="plusbutton" runat="server" Height="64px" OnClick="plusbutton_Click" Text="+" Width="64px" />
        <br />
        <asp:Button ID="clearbutton" runat="server" Height="64px" OnClick="clearbutton_Click" Text="C" Width="64px" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
