<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Log in<br />
            UserName:<br />
            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
            <br />
             Password:<br />
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="signIn" runat="server" OnClick="login" Text="Log in" />
             <br />
             <br />
            <asp:Button ID="newAccountButton" runat="server" OnClick="NewAccount" Text="Create new account!" />
            <br />
            <div id="newAccount" runat="server" style="visibility:hidden;">
                  Please select&nbsp; a user type!<br />
                 <asp:Button ID="inst" runat="server" OnClick="Inst" Text="Instructor" />
                 <asp:Button ID="stud" runat="server" OnClick="Stud" Text="Student" />
            </div>
        </div>
    </form>
</body>
</html>
