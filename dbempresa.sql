CREATE TABLE tbempresa(
	id_empresa INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    empresa VARCHAR(45),
    correo VARCHAR(50),
    nit VARCHAR(17),
    representante_legal VARCHAR(75),
    id_tipo_empresa INT(11) NOT NULL,
    id_estado INT(11) NOT NULL,
    direccion VARCHAR(150),
    logoempresa LONGTEXT
);

CREATE TABLE tbtipo_empresa(
	id_tipo_empresa INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    tipo_empresa VARCHAR(45)
);

CREATE TABLE tbestado(
	id_estado INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    estado VARCHAR(30)
);

CREATE TABLE tbcontacto(
	id_contacto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    contacto VARCHAR(14),
    id_empresa INT(11) NOT NULL
);

CREATE TABLE tbarticulo(
	id_articulo INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    articulo VARCHAR(50),
    tipo_articulo INT(2),
    id_empresa INT(11) NOT NULL,
    id_estado_articulo INT(11) NOT NULL
);

CREATE TABLE tbestado_articulo(
	id_estado_articulo INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    estado_articulo VARCHAR(45)
);

CREATE TABLE tbusuario(
	id_usuario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    usuario VARCHAR(45),
    clave VARCHAR(45),
    nombres VARCHAR(45),
    apellidos VARCHAR(45),
    documento VARCHAR(10),
    nacimiento DATE,
    email VARCHAR(50),
    intentos INT(2),
    id_empresa INT(11) NOT NULL,
    id_estado INT(11) NOT NULL,
    id_tipousuario INT(11) NOT NULL,
    foto LONGTEXT NOT NULL
);

CREATE TABLE tbtipo_usuario(
	id_tipo_usuario INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    tipo_usuario VARCHAR(45) NOT NULL
);


CREATE TABLE tbproducto(
	id_producto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    nombre_producto VARCHAR(45),
    codigo_producto VARCHAR(10) NOT NULL,
    id_categoria INT(11) NOT NULL,
    id_empresa INT(11) NOT NULL
);



CREATE TABLE tbcategoria_producto(
	id_categoria_producto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(45)
);

CREATE TABLE tbdetalles_producto(
	id_detalle_producto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    fecha_ingreso DATE,
    id_producto INT(11) NOT NULL,
    precio DOUBLE(5,2),
    fecha_empacado DATE,
    fecha_vencimiento DATE,
    existencia INT(11) NOT NULL,
    disponible INT(11),
    id_estado INT(1) NOT NULL,
    id_usuario INT(11) NOT NULL
);

CREATE TABLE tbestado_producto(
	id_estado_producto INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    estado_producto VARCHAR(45) NOT NULL
);

CREATE TABLE tbdetalle_factura(
	id_detalle_factura INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_detalle_producto INT(11) NOT NULL,
    cantidad INT(2),
    id_factura INT(11) NOT NULL,
    descuento DOUBLE,
    total_parcial DOUBLE NOT NULL
);


CREATE TABLE tbfactura(
	id_factura INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    id_usuario INT(11) NOT NULL,
    fecha_factura DATE NOT NULL,
    descuento DOUBLE(5,2),
    total_pago DOUBLE(5,2),
    id_estado INT(1) NOT NULL
);

CREATE TABLE tbestado_factura(
	id_estado_factura INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    estado_factura VARCHAR(40) NOT NULL
);

CREATE TABLE tbrespuesta(
	id_respuesta INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    respuesta VARCHAR(50),
    id_pregunta INT(11) NOT NULL,
    id_usuario INT(11) NOT NULL
);


CREATE TABLE tbpregunta(
	id_pregunta INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    pregunta VARCHAR(75)
);

ALTER TABLE tbempresa
ADD CONSTRAINT fk_empresa_tipo_empresa
FOREIGN KEY (id_tipo_empresa)
REFERENCES tbtipo_empresa (id_tipo_empresa);

ALTER TABLE tbempresa
ADD CONSTRAINT fk_empresa_estado
FOREIGN KEY (id_estado)
REFERENCES tbestado (id_estado);

ALTER TABLE tbrespuesta
ADD CONSTRAINT fk_respuesta_pregunta
FOREIGN KEY (id_pregunta)
REFERENCES tbpregunta (id_pregunta);

ALTER TABLE tbrespuesta 
ADD CONSTRAINT fk_respuesta_usuario
FOREIGN KEY (id_usuario)
REFERENCES tbusuario (id_usuario);

ALTER TABLE tbfactura
ADD CONSTRAINT fk_factura_usuario
FOREIGN KEY (id_usuario)
REFERENCES tbusuario(id_usuario);

ALTER TABLE tbfactura
ADD CONSTRAINT fk_factura_estado
FOREIGN KEy (id_estado)
REFERENCES tbestado_factura (id_estado_factura);

ALTER TABLE tbfactura MODIFY id_estado INT(1) NOT NULL;
ALTER TABLE tbempresa MODIFY logoempresa LONGTEXT DEFAULT NULL;

ALTER TABLE tbdetalle_factura
ADD CONSTRAINT fk_detallefac_detalleproduc
FOREIGN KEY (id_detalle_producto)
REFERENCES tbdetalles_producto (id_detalle_producto);

ALTER TABLE tbdetalle_factura
ADD CONSTRAINT fk_detallefac_factura
FOREIGN KEY (id_factura)
REFERENCES tbfactura (id_factura);
ALTER TABLE tbdetalles_producto
ADD CONSTRAINT fk_detalle_producto
FOREIGN KEY (id_producto)
REFERENCES tbproducto (id_producto);

ALTER TABLE tbdetalles_producto
ADD CONSTRAINT fk_detalle_estado
FOREIGN KEY (id_estado)
REFERENCES tbestado_producto (id_estado_producto);

ALTER TABLE tbdetalles_producto
ADD CONSTRAINT fk_detalle_usuario
FOREIGN KEY (id_usuario)
REFERENCES tbusuario (id_usuario);

ALTER TABLE tbproducto
ADD CONSTRAINT fk_producto_categoria
FOREIGN KEY (id_categoria)
REFERENCES tbcategoria_producto (id_categoria_producto);

ALTER TABLE tbproducto
ADD CONSTRAINT fk_producto_empresa
FOREIGN KEY (id_empresa)
REFERENCES tbempresa (id_empresa);

ALTER TABLE tbusuario
ADD CONSTRAINT fk_usuario_empresa
FOREIGN KEY (id_empresa)
REFERENCES tbempresa (id_empresa);

ALTER TABLE tbusuario
ADD CONSTRAINT fk_usuario_estado
FOREIGN KEY (id_estado)
REFERENCES tbestado (id_estado);

ALTER TABLE tbusuario
ADD CONSTRAINT fk_usuario_tipo_usuario
FOREIGN KEY (id_tipousuario)
REFERENCES tbtipo_usuario (id_tipo_usuario);

ALTER TABLE tbcontacto
ADD CONSTRAINT fk_contacto_empresa
FOREIGN KEY (id_empresa)
REFERENCES tbempresa(id_empresa);

ALTER TABLE tbarticulo
ADD CONSTRAINT fk_articulo_empresa
FOREIGN KEY (id_empresa)
REFERENCES tbempresa (id_empresa);

ALTER TABLE tbarticulo
ADD CONSTRAINT fk_articulo_estado
FOREIGN KEY (id_estado_articulo)
REFERENCES tbestado_articulo (id_estado_articulo);

INSERT INTO tbestado (estado) VALUES ("Activo"), ("Inactiva");
INSERT INTO tbtipo_empresa (tipo_empresa) VALUES ("Local"),("Nacional"),("Regional"),("Multinacional");