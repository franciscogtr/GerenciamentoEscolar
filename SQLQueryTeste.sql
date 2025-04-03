create database teste;
use teste;

-- Tabela e Procedures Usuário

create table Usuario(
	id_usuario INT IDENTITY(1,1) PRIMARY KEY, -- A coluna id_usuario será auto incremento
    nome_usuario VARCHAR(50) NOT NULL,         -- Coluna para o nome do usuário
    senha_usuario VARCHAR(100) NOT NULL,       -- Coluna para a senha do usuário
    email_usuario VARCHAR(100),                -- Coluna para o e-mail do usuário (opcional)
	tipo_usuario varchar(20) not null
  )  

  insert into Usuario values (
 'Admin', 'qwer', 'admin@mail.com', 'Administrador'
)
select*from usuario;
go

CREATE PROCEDURE sp_logar
    @email VARCHAR(100),
	@senha VARCHAR(100)
AS
BEGIN
    SELECT *FROM Usuario
    WHERE email_usuario = @email and senha_usuario = @senha;
END
Go

CREATE PROCEDURE sp_buscar_usuario
    @nome VARCHAR(50)
	
AS
BEGIN
    SELECT * FROM usuario
    WHERE nome_usuario like @nome;
END
Go

CREATE PROCEDURE sp_listar_usuario
AS
BEGIN
    SELECT *
    FROM usuario order by id_usuario;
END
go

CREATE PROCEDURE sp_crud_usuario
@id int,
@nome varchar(50),
@senha Varchar(100),
@email varchar (100),
@tipo varchar(20),
@action varchar(10) output
AS if(@action = '1')
BEGIN 
insert into Usuario values(@nome,@senha, @email,@tipo);
set @action = 'Inserido';
end


else if(@action = '2')
begin update usuario set nome_usuario = @nome, email_usuario = @email, senha_usuario = @senha,
tipo_usuario = @tipo where id_usuario = @id;
set @action = 'Editado';
end


else if(@action = '3') begin
    Delete FROM usuario where  id_usuario = @id;
	set @action = 'Removido';
END
go
drop procedure sp_buscar_usuario;

-- Tabela e Procedures Aluno

create table Aluno(
	id_aluno INT IDENTITY(1,1) PRIMARY KEY, -- A coluna id_usuario será auto incremento
    nome_aluno VARCHAR(50) NOT NULL,         -- Coluna para o nome do usuário
    telefone_aluno VARCHAR(15) NOT NULL,       -- Coluna para a senha do usuário
    email_aluno VARCHAR(100) not null,              -- Coluna para o e-mail do usuário (opcional)
	matricula_aluno varchar(6) not null,
	turma_aluno varchar(15) not null,
	curso_aluno varchar(15) not null
  )  

go

CREATE PROCEDURE sp_buscar_aluno
    @nome VARCHAR(50)	
AS
BEGIN
    SELECT * FROM Aluno
    WHERE nome_aluno like @nome;
END

Go
CREATE PROCEDURE sp_listar_aluno
AS
BEGIN
    SELECT *
    FROM Aluno order by id_aluno;
END
go
CREATE PROCEDURE sp_crud_aluno
@id int,
@nome varchar(50),
@matricula Varchar(6),
@curso varchar (50),
@turma varchar(50),
@email varchar (100),
@telefone varchar(11),
@action varchar(10) output
AS if(@action = '1')
BEGIN 
insert into Aluno values(@nome,@telefone,@email, @matricula,@turma, @curso);
set @action = 'Inserido';
end
else if(@action = '2')
begin update Aluno set nome_aluno = @nome, telefone_aluno = @telefone, email_aluno = @email,
matricula_aluno = @matricula, curso_aluno = @curso, turma_aluno = @turma 
where id_aluno = @id;
set @action = 'Editado';
end
else if(@action = '3') begin
    Delete FROM Aluno where  id_aluno = @id;
	set @action = 'Removido';
END


-- Tabela e Procedures Curso

 create table Curso(
	id_curso int identity(1,1) primary key,
	nome_curso varchar(50) not null
  )
  
  go

  CREATE PROCEDURE sp_listar_curso
AS
BEGIN
    SELECT *
    FROM Curso order by id_curso;
END

go
CREATE PROCEDURE sp_crud_curso
@id int,
@nome varchar(50),
@action varchar(10) output
AS if(@action = '1')
BEGIN 
insert into Curso values(@nome);
set @action = 'Inserido';
end


else if(@action = '2')
begin update Curso set nome_curso = @nome where id_curso = @id;
set @action = 'Editado';
end


else if(@action = '3') begin
    Delete FROM Curso where  id_curso = @id;
	set @action = 'Removido';
END
go

CREATE PROCEDURE sp_buscar_curso
    @nome VARCHAR(50)
	
AS
BEGIN
    SELECT * FROM Curso
    WHERE nome_curso like @nome;
END

-- Tabela e Procedures Turma
go

create table Turma(
	id_turma int identity(1,1) primary key,
	nome_turma varchar(50) not null
  )


go

CREATE PROCEDURE sp_buscar_turma
    @nome VARCHAR(50)
	
AS
BEGIN
    SELECT * FROM Turma
    WHERE nome_turma like @nome;
END

go

CREATE PROCEDURE sp_listar_turma
AS
BEGIN
    SELECT *
    FROM Turma order by id_turma;
END
go
CREATE PROCEDURE sp_crud_turma
@id int,
@nome varchar(50),
@action varchar(10) output
AS if(@action = '1')
BEGIN 
insert into Turma values(@nome);
set @action = 'Inserida';
end
else if(@action = '2')
begin update Turma set nome_turma = @nome where id_turma = @id;
set @action = 'Editada';
end
else if(@action = '3') begin
    Delete FROM Turma where  id_turma = @id;
	set @action = 'Removida';
END
go


-- Criação da tabela e procedurs Disciplina

create table Disciplina(
	id_disciplina int identity(1,1) primary key,
	nome_disciplina varchar(50) not null,
	nome_curso varchar(50) not null,
)

GO
create procedure sp_listar_disciplinas
AS
BEGIN
    SELECT * FROM Disciplina order by id_disciplina;
END
GO
CREATE PROCEDURE sp_crud_disciplina
@id int,
@nome varchar(50),
@curso varchar(50),
@action varchar(10) output
AS if(@action = '1')
BEGIN 
insert into Disciplina values(@nome,@curso);
set @action = 'Inserida';
end
else if(@action = '2')
begin update Disciplina set nome_disciplina = @nome, nome_curso = @curso where id_disciplina = @id;
set @action = 'Editada';
end
else if(@action = '3') begin
    Delete FROM Disciplina where  id_disciplina = @id;
	set @action = 'Removida';
END
GO

CREATE PROCEDURE sp_buscar_disciplina
    @nome VARCHAR(50)	
AS
BEGIN
    SELECT * FROM Disciplina
    WHERE nome_disciplina like @nome;
END
GO

-- Criação da Tabela e Porcedures Atividade

create table Atividade(
	id_atividade int identity(1,1) primary key,
	nome_atividade varchar(50) not null,
	curso_atividade varchar(50) not null,
	disciplina_atividade varchar(50) not null,
)

go

CREATE PROCEDURE sp_crud_atividade
@id int,
@nome varchar(50),
@curso varchar(50),
@disciplina varchar(50),
@action varchar(10) output
AS if(@action = '1')
BEGIN 
insert into Atividade values(@nome,@curso,@disciplina);
set @action = 'Inserida';
end
else if(@action = '2')
begin update Atividade set nome_atividade = @nome, curso_atividade = @curso, disciplina_atividade = @disciplina where id_atividade = @id;
set @action = 'Editada';
end
else if(@action = '3') begin
    Delete FROM Atividade where  id_atividade = @id;
	set @action = 'Removida';
END

GO

create procedure sp_listar_atividades
AS
BEGIN
    SELECT * FROM Atividade order by id_atividade;
END
GO

-- Criação da tabela e procedures Nota

create table Nota(
	id_nota int identity(1,1) primary key,
	nome_aluno varchar(50) not null,
	curso_aluno varchar(50) not null,
	turma_aluno varchar(50) not null,
	disciplina varchar(50) not null,
	atividade varchar(50) not null,
	nota float not null

)
go
create procedure sp_listar_notas
AS
BEGIN
    SELECT * FROM Nota order by id_nota;
END
GO


CREATE PROCEDURE sp_crud_notas
@id int,
@nome varchar(50),
@curso varchar(50),
@turma varchar(50),
@disciplina varchar(50),
@atividade varchar(50),
@nota float,
@action varchar(10) output
AS if(@action = '1')
BEGIN 
insert into Nota values(@nome, @curso, @turma, @disciplina, @atividade, @nota)
set @action = 'Inserida';
end
else if(@action = '2')
begin update Nota set @nome = nome_aluno, @curso = curso_aluno, @turma = turma_aluno, @disciplina = disciplina, @atividade = atividade, @nota = nota 
where id_nota = @id;
set @action = 'Editada';
end
else if(@action = '3') begin
    Delete FROM Nota where  id_nota = @id;
	set @action = 'Removida';
END
GO





