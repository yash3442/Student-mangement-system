<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="StudentManagementSystem.Students" %>
<!DOCTYPE html>
<html>
<head>
    <title>Student List</title>
</head>
<body style="font-family: Arial; background-color: #eef;">
    <h2>Student List</h2>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
    <br/>
    <a href="Default.aspx">Back to Add Student</a>
</body>
</html>
