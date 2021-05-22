<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentAddFeedback.aspx.cs" Inherits="GUCera.studentAddFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 298px">
    <form id="form1" runat="server">
        <div style="font:bold;font-size:large;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
            <asp:Button ID="home" runat="server" OnClick="Home" Text="Return To Home Page" Width="170px" />
         </div>
        <div id="feebackDiv" runat="server" style="font:bold;font-size:large;">
             <hr />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             Kindly add the course&#39;s code and your comment :<br />
             <hr />
             &nbsp;
             Course: &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="course" runat="server" Height="20px" Width="107px"></asp:TextBox>
            <br />
            <br />
             &nbsp;Comment&nbsp;:<br />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="fb" runat="server" Height="58px" Width="265px" MaxLength="100" TextMode="MultiLine"></asp:TextBox>
             <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="feedback" runat="server" Text="Submit Feedback" OnClick="Feedback"
                Width="257px" Height="35px" style="margin-top: 0px" BorderStyle="Groove" 
                BorderWidth="3px" Font-Bold="True" Font-Size="Large" />
             <hr />
        </div>
    </form>
</body>
</html>
