CREATE DATABASE login;
USE login;

drop database login;
CREATE TABLE `login`.`usuario` (
  `usuario_id` INT NOT NULL AUTO_INCREMENT,
  `usuario` VARCHAR(200) NOT NULL,
  `senha` VARCHAR(32) NOT NULL,
  `nome` VARCHAR(100) NOT NULL,
  `data_cadastro` DATETIME NOT NULL,
  PRIMARY KEY (`usuario_id`));

CREATE TABLE gerenciador(
id INT UNSIGNED AUTO_INCREMENT NOT NULL,
siteNome VARCHAR(200) NOT NULL,
login VARCHAR(100) NOT NULL,
senha VARCHAR(100) NOT NULL,
usuario int,
PRIMARY KEY(id),
foreign key(usuario) references usuario(`usuario_id`));
