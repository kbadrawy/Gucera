<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentSubmitAssignment.aspx.cs" Inherits="GUCera.studentSubmitAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            </div>
        <div id="divData" runat="server">
             Please Enter The following :
             <br />
             <br />
             Assignment Type&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="type" runat="server" Width="104px"></asp:TextBox>
            <br />
            <br />
            Assignment Number&nbsp;&nbsp;
            <asp:TextBox ID="number" runat="server" Width="104px"></asp:TextBox>
            <br />
            <br />
             Course ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <asp:TextBox ID="course" runat="server" Width="104px"></asp:TextBox>
             <br />
            <br />
              <asp:Button ID="submit" runat="server" OnClick="Submit" Text="Submit Assignment" Width="250px" />
            <br />
             
        </div>
 
    </form>
</body>
</html>
