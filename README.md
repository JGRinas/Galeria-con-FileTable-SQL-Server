# Galeria-con-FileTable-SQL-Server

Galería de archivos hecho con c# winform, con una base de datos de SQL Server, para el manejo de archivos se utilizó una tabla de usuario especializada, conocida como FILE TABLE
Para la creación del programa se tuvo en cuanta la creación de una Vista en la base de datos, en la cual se convirtió el tipo de dato HierarchyID del File table en un varchar(), debido a que el tipo de dato HierarchyID no es reconocido por las consultas a la base de datos dentro de la aplicación, generando errores en las mismas 
Dentro de la aplicación se pueden ver todos los archivos dentro del directorio, así como ver los archivos que son solo imagenes, videos y audios por separado.
