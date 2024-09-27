CREATE TABLE [dbo].[QLHinhAnh] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [SanPhamID]  INT            NOT NULL,
    [HinhAnh]    VARBINARY(MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY (SanPhamID) REFERENCES QLSanPham(ID)
);

ALTER TABLE [dbo].[QLSanPham]
DROP COLUMN [HinhAnh];
