<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentManagementSystem.Default" %>
<!DOCTYPE html>
<html>
<head>
    <title>Add Student</title>
</head>
<body style="font-family: Arial; background-color: #f4f4f4;">
    <h2>Add Student</h2>
    <form id="form1" runat="server">
        <label>Name:</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br/><br/>
        <label>Enrollment No:</label>
        <asp:TextBox ID="txtEnroll" runat="server"></asp:TextBox><br/><br/>
        <label>Department:</label>
        <asp:TextBox ID="txtDept" runat="server"></asp:TextBox><br/><br/>
        <asp:Button ID="btnAdd" runat="server" Text="Add Student" OnClick="btnAdd_Click" />
        <br/><br/>
        <a href="Students.aspx">View All Students</a>
    </form>
</body>
</html>
