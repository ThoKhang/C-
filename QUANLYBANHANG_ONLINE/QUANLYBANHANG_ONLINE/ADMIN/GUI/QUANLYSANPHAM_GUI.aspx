<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QUANLYSANPHAM_GUI.aspx.cs"
    Inherits="QUANLYBANHANG_ONLINE.ADMIN.GUI.QUANLYSANPHAM_GUI" %>


<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý sản phẩm</title>
    <style>
        .container { width:900px; margin:10px auto; font-family: Arial, Helvetica, sans-serif; }
        table.layout { width:100%; border-collapse:collapse; }
        table.layout td { padding:6px; vertical-align:middle; }
        .label { width:140px; text-align:right; padding-right:10px; font-weight:bold; }
        .input { width:100%; box-sizing:border-box; }
        .buttons { padding:10px 0; text-align:left; }
        .header { text-align:center; font-size:18px; font-weight:bold; padding:8px 0; }
        .grid-wrap { margin-top:10px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">QUẢN LÝ DANH SÁCH SẢN PHẨM</div>

            <table class="layout" border="0">
                <!-- Row 1: Mã danh mục | Mã sản phẩm -->
                <tr>
                    <td class="label">Mã danh mục</td>
                    <td>
                        <asp:DropDownList ID="drpDANHMUC" runat="server" CssClass="input"></asp:DropDownList>
                    </td>
                    <td class="label">Mã sản phẩm</td>
                    <td>
                        <asp:TextBox ID="txtMASANPHAM" runat="server" CssClass="input"></asp:TextBox>
                    </td>
                </tr>

                <!-- Row 2: Tên sản phẩm | Đơn giá -->
                <tr>
                    <td class="label">Tên sản phẩm</td>
                    <td>
                        <asp:TextBox ID="txtTENSANPHAM" runat="server" CssClass="input"></asp:TextBox>
                    </td>
                    <td class="label">Đơn giá</td>
                    <td>
                        <asp:TextBox ID="txtDONGIA" runat="server" CssClass="input"></asp:TextBox>
                    </td>
                </tr>

                <!-- Row 3: Số lượng | Upload Ảnh -->
                <tr>
                    <td class="label">Số lượng</td>
                    <td>
                        <asp:TextBox ID="txtSOLUONG" runat="server" CssClass="input"></asp:TextBox>
                    </td>
                    <td class="label">Upload Ảnh</td>
                    <td>
                        <asp:FileUpload ID="FileANHSANPHAM" runat="server" />
                    </td>
                </tr>

                <!-- Row 4: Mô tả (dàn trải 3 cột) -->
                <tr>
                    <td class="label">Mô tả</td>
                    <td colspan="3">
                        <asp:TextBox ID="txtMOTA" runat="server" TextMode="MultiLine" Rows="5" Width="100%" OnTextChanged="txtMOTA_TextChanged"></asp:TextBox>
                    </td>
                </tr>

                <!-- Row 5: Buttons -->
                <tr>
                    <td colspan="4" class="buttons">
                        <asp:Button ID="btnInsert" runat="server" Text="Thêm mới" OnClick="btnInsert_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Xóa"  OnClick="btnDelete_Click" CausesValidation="false" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Sửa" OnClick="btnUpdate_Click" />
                    </td>
                </tr>

                <!-- Row 6: GridView (toàn bộ chiều rộng) -->
                <tr>
                    <td colspan="4" class="grid-wrap">
                        <asp:GridView ID="grvSANPHAM" runat="server"
                            AutoGenerateColumns="False"
                            DataKeyNames="MASANPHAM"
                            Width="100%">
                            <Columns>
                                <asp:BoundField DataField="MASANPHAM" HeaderText="Mã sản phẩm" />
                                <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên sản phẩm" />
                                <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" DataFormatString="{0:N0}" />
                                <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
                                <asp:ImageField DataAlternateTextField="HINHANH" 
                DataImageUrlField="HINHANH" 
                DataImageUrlFormatString="~/IMAGES/{0}" 
                HeaderText="Ảnh"
                ControlStyle-Width="80px"
                ControlStyle-Height="60px">
</asp:ImageField>

                                
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
