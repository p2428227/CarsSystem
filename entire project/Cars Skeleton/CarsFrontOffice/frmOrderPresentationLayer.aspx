<%@ Page Language="C#" AutoEventWireup="true" CodeFile="frmOrderPresentationLayer.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            OrderID<asp:TextBox ID="txtOrderId" runat="server" style="margin-left: 64px"></asp:TextBox>
            <br />
            CustomerID<asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 43px"></asp:TextBox>
            <br />
            StaffID<asp:TextBox ID="txtStaffID" runat="server" style="margin-left: 74px"></asp:TextBox>
            <br />
            vinNumber<asp:TextBox ID="txtVinNumber" runat="server" style="margin-left: 51px"></asp:TextBox>
            <br />
            location<asp:TextBox ID="txtLocation" runat="server" style="margin-left: 72px"></asp:TextBox>
            <br />
            Finance&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="cbFinance" runat="server" />
            <br />
            Payment Status&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:CheckBox ID="cbPaymentStatus" runat="server" />
            <br />
            Date<asp:TextBox ID="txtDate" runat="server" style="margin-left: 92px"></asp:TextBox>
            <br />
            Price<asp:TextBox ID="txtPrice" runat="server" style="margin-left: 90px"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" Width="67px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="63px" />
        </div>
    </form>
</body>
</html>
