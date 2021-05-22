<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mobileNumber.aspx.cs" Inherits="GUCera.mobileNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="anotherOne" runat="server" style="visibility:hidden;">
                    Mobile number added successfuly!&nbsp;
                    <br />
                    Add another one?&nbsp;&nbsp;&nbsp;<br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="yes" runat="server" OnClick="Yes" Text="YES!!!" Width="60px" />  
                    <hr />
            <asp:Button ID="home2" runat="server" OnClick="Home" Text="Return To Home Page" Width="170px" />

                </div>       
        
        <div id="firstOne" runat="server">
            <hr />
            <br />
            <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           Mobile Number:&nbsp;&nbsp;&nbsp;&nbsp;   <asp:TextBox ID="Number" runat="server" Width="141px"></asp:TextBox>
            &nbsp;<br />
            <br />&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
             <asp:Button ID="mobile" runat="server" OnClick="Mobile" Text="Add Mobile Number" Width="170px" />
        <br />
        <br />
        <hr />
            <asp:Button ID="home" runat="server" OnClick="Home" Text="Return To Home Page" Width="170px" />
        </div>
         

    </form>
</body>
</html>
