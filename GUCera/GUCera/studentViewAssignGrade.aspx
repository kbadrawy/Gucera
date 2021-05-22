<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentViewAssignGrade.aspx.cs" Inherits="GUCera.studentViewAssignGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 368px">
    <form id="form1" runat="server">
        <div style="height: 430px">
             Please enter:<br />
             Assignment Number&nbsp;&nbsp;
            <asp:TextBox ID="number" runat="server" Width="104px"></asp:TextBox>
            <br />
            <br />
             Assignment Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="type" runat="server" Width="104px"></asp:TextBox>
            <br />
            <br />
             Course ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="course" runat="server" Width="104px"></asp:TextBox>
             <br />
            <br />
             <asp:Button ID="grade" runat="server" OnClick="Grade" Text="View My Grade" Width="250px" />
            <br />
            
            <br />
             <hr />
             <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
             <br />
             <br />

        </div>


    </form>
</body>
</html>
