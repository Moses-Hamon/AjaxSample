<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AjaxSample.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- You need a scriptmanager on the page (or its parent, such as a master page) --%>
        <asp:ScriptManager runat="server" />
        <asp:UpdatePanel runat="server">
            <ContentTemplate>
                <span>Command: </span>
                <asp:TextBox ID="txtCommand" runat="server" />
                <br />
                <span>Argument: </span>
                <asp:TextBox ID="txtArgument" runat="server" />
                <br />
                <asp:Button ID="btnRun" runat="server" Text="Run" OnClick="btnRun_Click" />
                <br />
                <span>Results</span>
                <br />
                <asp:Label ID="lblResults" runat="server" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
