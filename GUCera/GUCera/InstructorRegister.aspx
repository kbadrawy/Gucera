<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorRegister.aspx.cs" Inherits="GUCera.InstructorRegister" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:aliceblue;font-weight: bold;">
    <form id="form1" runat="server">
       <div> <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <br />
            <asp:Button ID="regDone" runat="server" OnClick="RegDone"
                Text="Login" Width="508px" style="visibility:hidden;" />
       </div>
        <div id="regForm" runat="server" style="height: 358px; width: 518px; position: fixed; top: 15px; left: 10px; font-size: 20px; font-family: Arial, Helvetica, sans-serif; font-weight: bold; font-style: normal; font-variant: normal;">
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <hr style="margin-top: 0px" />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Instructor Registration<br />
            <br />
            <hr />
            <br />
            <br />

            First Name&nbsp;
            <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Last Name&nbsp;&nbsp; 
            <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
            <br />
            <br />
             Password&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; &nbsp; 
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
            <br />
            <br />
             Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="Address"  runat="server"></asp:TextBox>
            <br />
            <br />
            Gender&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:DropDownList ID="Gender" runat="server">
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Male</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="register" runat="server" OnClick="Register" Text="Register" Width="244px" 
               style="font-weight: bold;background-color: black; 
                      color:white; font-size:30px; box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2), 0 6px 20px 0 rgba(0,0,0,0.19);"
                Height="37px" Font-Size="Larger" />
            <br />
        </div>
    </form>
</body>
</html>
