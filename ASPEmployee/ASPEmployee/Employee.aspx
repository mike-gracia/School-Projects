<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Employee.aspx.cs" Inherits="aspx2._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to Employee Lookup!
    </h2>
    <p>
        
        Choose An Employee:
        <asp:DropDownList ID="empSelectDropDown" runat="server" 
            onselectedindexchanged="empSelectDropDown_SelectedIndexChanged" 
            DataMember="EMPID">
        </asp:DropDownList>
        
    &nbsp;
        <asp:Button ID="LoadButton" runat="server" onclick="LoadButton_Click" 
            Text="Load" />
        
    </p>
    <p>
        
        First Name&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="fnameTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp; Last Name&nbsp;
        <asp:TextBox ID="lnameTextBox" runat="server"></asp:TextBox>
        
    </p>
    <p>
        
        Phone&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Salary&nbsp;
        <asp:TextBox ID="salaryTextBox" runat="server"></asp:TextBox>
    </p>
    <p>
        
        Department&nbsp;
        <asp:DropDownList ID="DeptDropDown" runat="server">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Sex<asp:DropDownList ID="sexDropDown" runat="server">
            <asp:ListItem>M</asp:ListItem>
            <asp:ListItem>F</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        
        &nbsp;</p>
    <p>
        
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
        
        <asp:Label ID="WarningLabel" runat="server" Text="Label"></asp:Label>
        
    </p>

</asp:Content>
