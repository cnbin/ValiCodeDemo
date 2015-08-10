<%@ Page Title="主页" Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ValiCodeDemo._Default" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>验证码测试</title>
</head>
<body>
    <form id="form1" runat="server">
    <center>
    <fieldset>
    <legend>验证码测试</legend>
        请输入验证码：<asp:TextBox ID="valid" runat="server"></asp:TextBox>  
        <asp:Image ID="Image1" runat="server" />
        <asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" />
    </fieldset>
    </center>
    </form>
</body>
</html>
