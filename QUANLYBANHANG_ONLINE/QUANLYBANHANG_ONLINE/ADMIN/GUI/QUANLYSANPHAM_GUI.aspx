<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QUANLYSANPHAM_GUI.aspx.cs" Inherits="QUANLYBANHANG_ONLINE.ADMIN.GUI.QUANLYSANPHAM_GUI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Quản lý sản phẩm</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        body {
            background: linear-gradient(135deg, #74ebd5, #ACB6E5);
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        h2 {
            color: #ffffff;
            margin-bottom: 20px;
            font-weight: bold;
            text-shadow: 2px 2px 6px rgba(0,0,0,0.3);
        }

        .gridview {
            border: none;
            border-radius: 12px;
            overflow: hidden;
            box-shadow: 0 4px 12px rgba(0,0,0,0.15);
        }

        .gridview th {
            background: linear-gradient(90deg, #4e54c8, #8f94fb);
            color: white;
            font-weight: bold;
            text-transform: uppercase;
            padding: 10px;
        }

        .gridview tr:nth-child(even) {
            background-color: #f9f9ff;
        }

        .gridview tr:hover {
            background-color: #e0f7fa !important;
            transition: background 0.3s ease;
        }

        .btn-success {
            background: linear-gradient(90deg, #00c853, #64dd17);
            border: none;
            font-weight: bold;
        }

        .btn-warning {
            background: linear-gradient(90deg, #ffb300, #ff6f00);
            border: none;
            font-weight: bold;
            color: #fff;
        }

        .btn-danger {
            background: linear-gradient(90deg, #d50000, #ff1744);
            border: none;
            font-weight: bold;
        }

        .form-label {
            font-weight: 600;
            color: #2c3e50;
        }

        .form-control, .form-select {
            border-radius: 8px;
            border: 1px solid #b0bec5;
            box-shadow: inset 0 1px 3px rgba(0,0,0,0.1);
        }

        .form-control:focus, .form-select:focus {
            border-color: #4e54c8;
            box-shadow: 0 0 6px rgba(78,84,200,0.5);
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="container py-4">
        <div class="text-center">
            <h2>QUẢN LÝ DANH SÁCH SẢN PHẨM</h2>
        </div>

        <!-- Form nhập sản phẩm -->
        <div class="row g-3">
            <div class="col-md-6">
                <label class="form-label">Mã danh mục</label>
                <asp:DropDownList ID="drpDANHMUC" runat="server" CssClass="form-select"></asp:DropDownList>
            </div>
            <div class="col-md-6">
                <label class="form-label">Mã sản phẩm</label>
                <asp:TextBox ID="txtMASANPHAM" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
                <label class="form-label">Tên sản phẩm</label>
                <asp:TextBox ID="txtTENSANPHAM" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
                <label class="form-label">Đơn giá</label>
                <asp:TextBox ID="txtDONGIA" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
                <label class="form-label">Số lượng</label>
                <asp:TextBox ID="txtSOLUONG" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-md-6">
                <label class="form-label">Upload Ảnh</label>
                <asp:FileUpload ID="FileANHSANPHAM" runat="server" CssClass="form-control" />
            </div>
            <div class="col-12">
                <label class="form-label">Mô tả</label>
                <asp:TextBox ID="txtMOTA" runat="server" TextMode="MultiLine" Rows="3" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="text-center my-3">
            <asp:Button ID="btnInsert" runat="server" Text="Thêm mới" CssClass="btn btn-success mx-3 px-4" OnClick="btnThem_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Sửa" CssClass="btn btn-warning mx-3 px-4" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Xóa" CssClass="btn btn-danger mx-3 px-4" OnClick="btnDelete_Click" />
        </div>

        <!-- Thông báo -->
        <div class="text-center">
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" CssClass="fw-bold"></asp:Label>
        </div>

        <!-- GridView -->
        <div class="grid-container mt-4">
            <asp:GridView ID="grvSANPHAM" runat="server" CssClass="table table-hover table-bordered text-center gridview"
                Width="100%" AutoGenerateColumns="False"
                DataKeyNames="MASANPHAM,HINHANH,MADANHMUC"
                OnSelectedIndexChanged="grvSANPHAM_SelectedIndexChanged">
                <Columns >
                    <asp:CommandField ShowSelectButton="True" SelectText="Chọn" HeaderText="Thao tác" />
                    <asp:BoundField DataField="MASANPHAM" HeaderText="Mã sản phẩm" />
                    <asp:BoundField DataField="TENSANPHAM" HeaderText="Tên sản phẩm" />
                    <asp:BoundField DataField="DONGIA" HeaderText="Đơn giá" />
                    <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng" />
                    <asp:BoundField DataField="MOTA" HeaderText="Mô tả" />
                    <asp:ImageField DataImageUrlField="HINHANH" DataImageUrlFormatString="~/images/{0}" HeaderText="Ảnh sản phẩm">
                        <ControlStyle Height="100px" />
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
