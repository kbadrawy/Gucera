<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentViewAssignment.aspx.cs" Inherits="GUCera.studentViewAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 368px">
    <form id="form1" runat="server">
        <div style="height: 430px">
             Please enter the ID of the course:<br />
            <asp:TextBox ID="course" runat="server" Width="129px"></asp:TextBox>
            <asp:Button ID="assign" runat="server" OnClick="Assignment" Text="confirm" Width="70px" />

            <br />
             <hr />
             <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
             <br />
             <br />

        </div>


    </form>
</body>
</html>
