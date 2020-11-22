using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Easyphoto.Core.Domain;

namespace Easyphoto.Infrastructure.Data
{
    public partial class EasyphotoDbContext : DbContext
    {
        public EasyphotoDbContext()
        {
        }

        public EasyphotoDbContext(DbContextOptions<EasyphotoDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accion> Accion { get; set; }
        public virtual DbSet<ClasesVentas> ClasesVentas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<ControlProducto> ControlProducto { get; set; }
        public virtual DbSet<ControlUsuarios> ControlUsuarios { get; set; }
        public virtual DbSet<DetalleEntradas> DetalleEntradas { get; set; }
        public virtual DbSet<DetalleOrdenCompra> DetalleOrdenCompra { get; set; }
        public virtual DbSet<Entradas> Entradas { get; set; }
        public virtual DbSet<Entregas> Entregas { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<GruposProductos> GruposProductos { get; set; }
        public virtual DbSet<GruposServicios> GruposServicios { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<MovimientosProductos> MovimientosProductos { get; set; }
        public virtual DbSet<OrdenCompra> OrdenCompra { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<PapelFotografico> PapelFotografico { get; set; }
        public virtual DbSet<PrecioTamañosImp> PrecioTamañosImp { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<ProductosStockBajos> ProductosStockBajos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<RolAccion> RolAccion { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<TamañosImp> TamañosImp { get; set; }
        public virtual DbSet<TrabajosEntregados> TrabajosEntregados { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // if (!optionsBuilder.IsConfigured)
           // {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               // optionsBuilder.UseMySQL("database=easyphoto;server=localhost;port=3306;user id=Yeisson;password=12345");
           // }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accion>(entity =>
            {
                entity.HasKey(e => e.IdAccion)
                    .HasName("PRIMARY");

                entity.ToTable("accion");

                entity.HasIndex(e => e.Modulo)
                    .HasName("mod_acc_idx");

                entity.Property(e => e.IdAccion)
                    .HasColumnName("ID_Accion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accion1)
                    .IsRequired()
                    .HasColumnName("Accion")
                    .HasMaxLength(20);

                entity.Property(e => e.Modulo).HasColumnType("int(11)");

                entity.HasOne(d => d.ModuloNavigation)
                    .WithMany(p => p.Accion)
                    .HasForeignKey(d => d.Modulo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("mod_acc");
            });

            modelBuilder.Entity<ClasesVentas>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PRIMARY");

                entity.ToTable("clases_ventas");

                entity.Property(e => e.IdVenta)
                    .HasColumnName("ID_Venta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TipoVenta)
                    .HasColumnName("Tipo_venta")
                    .HasMaxLength(12)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.ToTable("clientes");

                entity.HasIndex(e => e.TipoCliente)
                    .HasName("rolc");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("ID_Cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido1)
                    .HasColumnName("Apellido_1")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Apellido2)
                    .HasColumnName("Apellido_2")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasColumnName("Correo_Electronico")
                    .HasMaxLength(40);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ImagenLogo)
                    .HasColumnName("Imagen_Logo")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre1)
                    .HasColumnName("Nombre_1")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre2)
                    .HasColumnName("Nombre_2")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumeroDocumento)
                    .HasColumnName("Numero_Documento")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TipoCliente)
                    .HasColumnName("Tipo_Cliente")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.TipoDocumento)
                    .HasColumnName("Tipo_Documento")
                    .HasMaxLength(4)
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.TipoClienteNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.TipoCliente)
                    .HasConstraintName("rolc");
            });

            modelBuilder.Entity<ControlProducto>(entity =>
            {
                entity.HasKey(e => e.IdControlP)
                    .HasName("PRIMARY");

                entity.ToTable("control_producto");

                entity.Property(e => e.IdControlP)
                    .HasColumnName("ID_Control_P")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fecha)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hora)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdGrupo)
                    .HasColumnName("ID_Grupo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("ID_Producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImagenProducto)
                    .HasColumnName("Imagen_Producto")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PVtaAficionado).HasColumnName("P_Vta_Aficionado");

                entity.Property(e => e.PVtaProfesional).HasColumnName("P_Vta_Profesional");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<ControlUsuarios>(entity =>
            {
                entity.HasKey(e => e.IdControlU)
                    .HasName("PRIMARY");

                entity.ToTable("control_usuarios");

                entity.Property(e => e.IdControlU)
                    .HasColumnName("ID_Control_U")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Accion)
                    .HasColumnName("accion")
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Apellido1)
                    .HasColumnName("Apellido_1")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Apellido2)
                    .HasColumnName("Apellido_2")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasColumnName("Correo_Electronico")
                    .HasMaxLength(40);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Hora)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdUsuarios)
                    .HasColumnName("ID_Usuarios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImagenPerfil)
                    .HasColumnName("Imagen_Perfil")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre1)
                    .HasColumnName("Nombre_1")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre2)
                    .HasColumnName("Nombre_2")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasColumnName("Numero_Documento")
                    .HasMaxLength(15);

                entity.Property(e => e.Rol)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasColumnName("Tipo_Documento")
                    .HasMaxLength(4);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<DetalleEntradas>(entity =>
            {
                entity.HasKey(e => e.IdDetalleEntrada)
                    .HasName("PRIMARY");

                entity.ToTable("detalle_entradas");

                entity.HasIndex(e => e.IdEntrada)
                    .HasName("ID_Entrada");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("ID_Productos");

                entity.Property(e => e.IdDetalleEntrada)
                    .HasColumnName("ID_Detalle_Entrada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.IdEntrada)
                    .HasColumnName("ID_Entrada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("ID_Producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubTotal).HasColumnName("Sub_Total");

                entity.HasOne(d => d.IdEntradaNavigation)
                    .WithMany(p => p.DetalleEntradas)
                    .HasForeignKey(d => d.IdEntrada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Entrada");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleEntradas)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Productos");
            });

            modelBuilder.Entity<DetalleOrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdDetalleOrden)
                    .HasName("PRIMARY");

                entity.ToTable("detalle_orden_compra");

                entity.HasIndex(e => e.IdOrden)
                    .HasName("ID_Ordenv");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("ID_Producto");

                entity.HasIndex(e => e.IdServicio)
                    .HasName("ID_Serviciov");

                entity.HasIndex(e => e.IdTamañoImp)
                    .HasName("ID_Tamaño_Imp");

                entity.Property(e => e.IdDetalleOrden)
                    .HasColumnName("ID_Detalle_Orden")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.IdOrden)
                    .HasColumnName("ID_Orden")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("ID_Producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdServicio)
                    .HasColumnName("ID_Servicio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTamañoImp)
                    .HasColumnName("ID_Tamaño_Imp")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.SubTotal).HasColumnName("Sub_Total");

                entity.Property(e => e.VUnitario).HasColumnName("V_Unitario");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.DetalleOrdenCompra)
                    .HasForeignKey(d => d.IdOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Ordenv");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.DetalleOrdenCompra)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Producto");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.DetalleOrdenCompra)
                    .HasForeignKey(d => d.IdServicio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Serviciov");

                entity.HasOne(d => d.IdTamañoImpNavigation)
                    .WithMany(p => p.DetalleOrdenCompra)
                    .HasForeignKey(d => d.IdTamañoImp)
                    .HasConstraintName("ID_Tamaño_Imp");
            });

            modelBuilder.Entity<Entradas>(entity =>
            {
                entity.HasKey(e => e.IdEntrada)
                    .HasName("PRIMARY");

                entity.ToTable("entradas");

                entity.HasIndex(e => e.IdProveedor)
                    .HasName("ID_Proveedor");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("ID_Usuarios");

                entity.Property(e => e.IdEntrada)
                    .HasColumnName("ID_Entrada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Abono).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Descuento).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("ID_proveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Saldo).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VTotal).HasColumnName("V_Total");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Entradas)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Proveedor");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Entradas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Usuarios");
            });

            modelBuilder.Entity<Entregas>(entity =>
            {
                entity.HasKey(e => e.IdEntrega)
                    .HasName("PRIMARY");

                entity.ToTable("entregas");

                entity.HasIndex(e => e.ConscFactura)
                    .HasName("Consc_Fact");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("ID_Clientes");

                entity.HasIndex(e => e.IdOrden)
                    .HasName("ID_Sobre");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("ID_Usuariot");

                entity.Property(e => e.IdEntrega)
                    .HasColumnName("ID_Entrega")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConscFactura)
                    .HasColumnName("Consc_Factura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("ID_Cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdOrden)
                    .HasColumnName("ID_Orden")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Saldo).HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.ConscFacturaNavigation)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.ConscFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Consc_Fact");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Clientes");

                entity.HasOne(d => d.IdOrdenNavigation)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.IdOrden)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Sobre");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Entregas)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Usuariot");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.ConscFactura)
                    .HasName("PRIMARY");

                entity.ToTable("factura");

                entity.HasIndex(e => e.IdVenta)
                    .HasName("ID_Venta");

                entity.Property(e => e.ConscFactura)
                    .HasColumnName("Consc_Factura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Efectivo).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdVenta)
                    .HasColumnName("ID_Venta")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tarjeta).HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Venta");
            });

            modelBuilder.Entity<GruposProductos>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PRIMARY");

                entity.ToTable("grupos_productos");

                entity.Property(e => e.IdGrupo)
                    .HasColumnName("ID_Grupo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Imagen)
                    .HasColumnType("longblob")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<GruposServicios>(entity =>
            {
                entity.HasKey(e => e.IdGrupo)
                    .HasName("PRIMARY");

                entity.ToTable("grupos_servicios");

                entity.Property(e => e.IdGrupo)
                    .HasColumnName("ID_Grupo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Imagen)
                    .HasColumnType("longblob")
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PRIMARY");

                entity.ToTable("modulo");

                entity.Property(e => e.IdModulo)
                    .HasColumnName("ID_Modulo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Modulo1)
                    .IsRequired()
                    .HasColumnName("Modulo")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<MovimientosProductos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("movimientos_productos");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(32,0)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductoOServicio)
                    .HasColumnName("Producto o Servicio")
                    .HasMaxLength(137)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Total).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValorUnitario).HasColumnName("Valor Unitario");
            });

            modelBuilder.Entity<OrdenCompra>(entity =>
            {
                entity.HasKey(e => e.IdOrden)
                    .HasName("PRIMARY");

                entity.ToTable("orden_compra");

                entity.HasIndex(e => e.ConscFactura)
                    .HasName("Consc_Factura");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("ID_Cliente");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("ID_Usuario");

                entity.Property(e => e.IdOrden)
                    .HasColumnName("ID_Orden")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Abono).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ConscFactura)
                    .HasColumnName("Consc_Factura")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descuento).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("ID_Cliente")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Iva)
                    .HasColumnName("IVA")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Saldo).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.VTotal).HasColumnName("V_Total");

                entity.HasOne(d => d.ConscFacturaNavigation)
                    .WithMany(p => p.OrdenCompra)
                    .HasForeignKey(d => d.ConscFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Consc_Factura");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.OrdenCompra)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Cliente");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.OrdenCompra)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Usuario");
            });

            modelBuilder.Entity<Pagos>(entity =>
            {
                entity.HasKey(e => e.IdEntrada)
                    .HasName("PRIMARY");

                entity.ToTable("pagos");

                entity.HasIndex(e => e.IdProveedor)
                    .HasName("ID_ProveedorE");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("ID_UsuarioE");

                entity.Property(e => e.IdEntrada)
                    .HasColumnName("ID_Entrada")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdProveedor)
                    .HasColumnName("ID_Proveedor")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdUsuario)
                    .HasColumnName("ID_Usuario")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Saldo).HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdEntradaNavigation)
                    .WithOne(p => p.Pagos)
                    .HasForeignKey<Pagos>(d => d.IdEntrada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Entradas");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_ProveedorE");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Pagos)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_UsuarioE");
            });

            modelBuilder.Entity<PapelFotografico>(entity =>
            {
                entity.HasKey(e => e.IdPapel)
                    .HasName("PRIMARY");

                entity.ToTable("papel_fotografico");

                entity.HasIndex(e => e.IdProducto)
                    .HasName("ID_Products");

                entity.Property(e => e.IdPapel)
                    .HasColumnName("ID_Papel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Embalaje)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.IdProducto)
                    .HasColumnName("ID_Producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LongCant)
                    .HasColumnName("Long_Cant")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.PapelFotografico)
                    .HasForeignKey(d => d.IdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ID_Products");
            });

            modelBuilder.Entity<PrecioTamañosImp>(entity =>
            {
                entity.HasKey(e => e.IdPrecio)
                    .HasName("PRIMARY");

                entity.ToTable("precio_tamaños_imp");

                entity.HasIndex(e => e.Tamaño)
                    .HasName("Tamaño");

                entity.Property(e => e.IdPrecio)
                    .HasColumnName("ID_Precio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasColumnType("int(11)");

                entity.Property(e => e.PVtaAficionado).HasColumnName("P_Vta_Aficionado");

                entity.Property(e => e.PVtaProfesional).HasColumnName("P_Vta_Profesional");

                entity.Property(e => e.Tamaño)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.HasOne(d => d.TamañoNavigation)
                    .WithMany(p => p.PrecioTamañosImp)
                    .HasPrincipalKey(p => p.TamañoImp)
                    .HasForeignKey(d => d.Tamaño)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Tamaño");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PRIMARY");

                entity.ToTable("productos");

                entity.HasIndex(e => e.IdGrupo)
                    .HasName("ID_Grupo");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("ID_Producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdGrupo)
                    .HasColumnName("ID_Grupo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ImgProducto)
                    .HasColumnName("Img_Producto")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PVtaAficionado).HasColumnName("P_Vta_Aficionado");

                entity.Property(e => e.PVtaProfesional).HasColumnName("P_Vta_Profesional");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Productos)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("ID_Grupo");
            });

            modelBuilder.Entity<ProductosStockBajos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("productos_stock_bajos");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(80)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdGrupo)
                    .HasColumnName("ID_Grupo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdProducto)
                    .HasColumnName("ID_Producto")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ImgProducto)
                    .HasColumnName("Img_Producto")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.PVtaAficionado).HasColumnName("P_Vta_Aficionado");

                entity.Property(e => e.PVtaProfesional).HasColumnName("P_Vta_Profesional");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.IdProveedores)
                    .HasName("PRIMARY");

                entity.ToTable("proveedores");

                entity.Property(e => e.IdProveedores)
                    .HasColumnName("ID_Proveedores")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasColumnName("Correo_Electronico")
                    .HasMaxLength(40);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ImagenLogo)
                    .HasColumnName("Imagen_Logo")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnName("NIT")
                    .HasMaxLength(15);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.Property(e => e.IdRol)
                    .HasColumnName("ID_Rol")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rol1)
                    .IsRequired()
                    .HasColumnName("Rol")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<RolAccion>(entity =>
            {
                entity.ToTable("rol_accion");

                entity.HasIndex(e => e.IdAccion)
                    .HasName("accion");

                entity.HasIndex(e => e.IdRol)
                    .HasName("rol");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdAccion)
                    .HasColumnName("ID_Accion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRol)
                    .HasColumnName("ID_Rol")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdAccionNavigation)
                    .WithMany(p => p.RolAccion)
                    .HasForeignKey(d => d.IdAccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("accion");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.RolAccion)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rol");
            });

            modelBuilder.Entity<Servicios>(entity =>
            {
                entity.HasKey(e => e.IdServicio)
                    .HasName("PRIMARY");

                entity.ToTable("servicios");

                entity.HasIndex(e => e.IdGrupo)
                    .HasName("ID_Grupos_idx");

                entity.Property(e => e.IdServicio)
                    .HasColumnName("ID_Servicio")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Combo)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(45)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdGrupo)
                    .HasColumnName("ID_Grupo")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.Servicios)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("ID_Grupos");
            });

            modelBuilder.Entity<TamañosImp>(entity =>
            {
                entity.HasKey(e => e.IdTamañoImp)
                    .HasName("PRIMARY");

                entity.ToTable("tamaños_imp");

                entity.HasIndex(e => e.IdPapel)
                    .HasName("ID_Papel");

                entity.HasIndex(e => e.TamañoImp)
                    .HasName("Tamaño_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdTamañoImp)
                    .HasColumnName("ID_Tamaño_Imp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Consume)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.IdPapel)
                    .HasColumnName("ID_Papel")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.TamañoImp)
                    .IsRequired()
                    .HasColumnName("Tamaño_Imp")
                    .HasMaxLength(12);

                entity.HasOne(d => d.IdPapelNavigation)
                    .WithMany(p => p.TamañosImp)
                    .HasForeignKey(d => d.IdPapel)
                    .HasConstraintName("ID_Papel");
            });

            modelBuilder.Entity<TrabajosEntregados>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("trabajos_entregados");

                entity.Property(e => e.Abono).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Cliente)
                    .HasMaxLength(25)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Descuento).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.EntregadoPor)
                    .HasColumnName("Entregado Por")
                    .HasMaxLength(63)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.FechaYHoraDeCompra)
                    .IsRequired()
                    .HasColumnName("Fecha y Hora de Compra")
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.FechaYHoraDeEntrega)
                    .IsRequired()
                    .HasColumnName("Fecha y Hora de Entrega")
                    .HasMaxLength(24)
                    .HasDefaultValueSql("''''''");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(63)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.OrdenNo)
                    .HasColumnName("Orden No")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Saldo).HasDefaultValueSql("'NULL'");

                entity.Property(e => e.ValorTotal).HasColumnName("Valor Total");

                entity.Property(e => e.Vendedor)
                    .HasMaxLength(63)
                    .HasDefaultValueSql("'NULL'");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PRIMARY");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Rol)
                    .HasName("rolu");

                entity.Property(e => e.IdUsuarios)
                    .HasColumnName("ID_Usuarios")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido1)
                    .HasColumnName("Apellido_1")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Apellido2)
                    .HasColumnName("Apellido_2")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasColumnName("Correo_Electronico")
                    .HasMaxLength(40);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ImagenPerfil)
                    .HasColumnName("Imagen_Perfil")
                    .HasMaxLength(30)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre1)
                    .HasColumnName("Nombre_1")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.Nombre2)
                    .HasColumnName("Nombre_2")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("'NULL'");

                entity.Property(e => e.NumeroDocumento)
                    .IsRequired()
                    .HasColumnName("Numero_Documento")
                    .HasMaxLength(15);

                entity.Property(e => e.Rol).HasColumnType("int(11)");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasColumnName("Tipo_Documento")
                    .HasMaxLength(4);

                entity.HasOne(d => d.RolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Rol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("rolu");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
