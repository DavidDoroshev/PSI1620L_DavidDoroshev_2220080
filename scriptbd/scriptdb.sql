-- --------------------------------------------------------
-- Host:                         devlab.thenotepad.eu
-- Server version:               Microsoft SQL Server 2019 (RTM-CU15) (KB5008996) - 15.0.4198.2
-- Server OS:                    Linux (Ubuntu 20.04.3 LTS) <X64>
-- HeidiSQL Version:             12.0.0.6468
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for PSI20L_DavidDoroshev_2220080
DROP DATABASE IF EXISTS "PSI20L_DavidDoroshev_2220080";
CREATE DATABASE IF NOT EXISTS "PSI20L_DavidDoroshev_2220080";
USE "PSI20L_DavidDoroshev_2220080";

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.admin
DROP TABLE IF EXISTS "admin";
CREATE TABLE IF NOT EXISTS "admin" (
	"id" INT NOT NULL,
	"nome" VARCHAR(5) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"pass" INT NOT NULL,
	PRIMARY KEY ("id")
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.admin: -1 rows
DELETE FROM "admin";
/*!40000 ALTER TABLE "admin" DISABLE KEYS */;
INSERT INTO "admin" ("id", "nome", "pass") VALUES
	(1, 'admin', 1);
/*!40000 ALTER TABLE "admin" ENABLE KEYS */;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.cliente
DROP TABLE IF EXISTS "cliente";
CREATE TABLE IF NOT EXISTS "cliente" (
	"id" INT NOT NULL,
	"nome" VARCHAR(25) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"password" VARCHAR(15) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"codigo_postal_cliente" VARCHAR(8) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("id"),
	FOREIGN KEY INDEX "FK__cliente__codigo___46E78A0C" ("codigo_postal_cliente"),
	CONSTRAINT "FK__cliente__codigo___46E78A0C" FOREIGN KEY ("codigo_postal_cliente") REFERENCES "codigo_postal" ("codigo_postal") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.cliente: -1 rows
DELETE FROM "cliente";
/*!40000 ALTER TABLE "cliente" DISABLE KEYS */;
INSERT INTO "cliente" ("id", "nome", "password", "codigo_postal_cliente") VALUES
	(54, 'David', 'Por', '1675-017'),
	(57, 'Joao', 'Midd', '2820-495'),
	(59, 'Carlos', 'Mid', '2870-231');
/*!40000 ALTER TABLE "cliente" ENABLE KEYS */;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.codigo_postal
DROP TABLE IF EXISTS "codigo_postal";
CREATE TABLE IF NOT EXISTS "codigo_postal" (
	"codigo_postal" VARCHAR(8) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"distrito_codigo" VARCHAR(25) NULL DEFAULT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("codigo_postal"),
	FOREIGN KEY INDEX "FK__codigo_po__distr__48CFD27E" ("distrito_codigo"),
	CONSTRAINT "FK__codigo_po__distr__48CFD27E" FOREIGN KEY ("distrito_codigo") REFERENCES "distrito_tabela" ("distrito") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.codigo_postal: -1 rows
DELETE FROM "codigo_postal";
/*!40000 ALTER TABLE "codigo_postal" DISABLE KEYS */;
INSERT INTO "codigo_postal" ("codigo_postal", "distrito_codigo") VALUES
	('1675-017', 'Odivelas'),
	('2820-495', 'Almada'),
	('2870-231', 'Setúbal');
/*!40000 ALTER TABLE "codigo_postal" ENABLE KEYS */;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.conselho_tabela
DROP TABLE IF EXISTS "conselho_tabela";
CREATE TABLE IF NOT EXISTS "conselho_tabela" (
	"conselho" VARCHAR(15) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("conselho")
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.conselho_tabela: -1 rows
DELETE FROM "conselho_tabela";
/*!40000 ALTER TABLE "conselho_tabela" DISABLE KEYS */;
INSERT INTO "conselho_tabela" ("conselho") VALUES
	('Charneca'),
	('Montijo'),
	('Pontinha');
/*!40000 ALTER TABLE "conselho_tabela" ENABLE KEYS */;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.distrito_tabela
DROP TABLE IF EXISTS "distrito_tabela";
CREATE TABLE IF NOT EXISTS "distrito_tabela" (
	"distrito" VARCHAR(25) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"conselho_distrito" VARCHAR(15) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("distrito"),
	FOREIGN KEY INDEX "FK__distrito___conse__4BAC3F29" ("conselho_distrito"),
	CONSTRAINT "FK__distrito___conse__4BAC3F29" FOREIGN KEY ("conselho_distrito") REFERENCES "conselho_tabela" ("conselho") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.distrito_tabela: -1 rows
DELETE FROM "distrito_tabela";
/*!40000 ALTER TABLE "distrito_tabela" DISABLE KEYS */;
INSERT INTO "distrito_tabela" ("distrito", "conselho_distrito") VALUES
	('Almada', 'Charneca'),
	('Odivelas', 'Pontinha'),
	('Setúbal', 'Montijo');
/*!40000 ALTER TABLE "distrito_tabela" ENABLE KEYS */;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.especialidade_tabela
DROP TABLE IF EXISTS "especialidade_tabela";
CREATE TABLE IF NOT EXISTS "especialidade_tabela" (
	"especialidade" VARCHAR(25) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"profissao" INT NOT NULL,
	PRIMARY KEY ("especialidade"),
	FOREIGN KEY INDEX "FK__especiali__profi__74AE54BC" ("profissao"),
	CONSTRAINT "FK__especiali__profi__74AE54BC" FOREIGN KEY ("profissao") REFERENCES "profissao_tabela" ("id_profissao") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.especialidade_tabela: -1 rows
DELETE FROM "especialidade_tabela";
/*!40000 ALTER TABLE "especialidade_tabela" DISABLE KEYS */;
INSERT INTO "especialidade_tabela" ("especialidade", "profissao") VALUES
	('Cardiologia', 1),
	('Manicure', 3),
	('Pedicure', 3);
/*!40000 ALTER TABLE "especialidade_tabela" ENABLE KEYS */;

-- Dumping structure for function PSI20L_DavidDoroshev_2220080.fn_diagramobjects
DROP FUNCTION IF EXISTS "fn_diagramobjects";
DELIMITER //

	CREATE FUNCTION dbo.fn_diagramobjects() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
	//
DELIMITER ;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.marcacoes_cliente
DROP TABLE IF EXISTS "marcacoes_cliente";
CREATE TABLE IF NOT EXISTS "marcacoes_cliente" (
	"id" INT NOT NULL,
	"dia_marcacao" DATE NOT NULL,
	"hora" TIME NOT NULL,
	"nome_cliente_id" INT NOT NULL,
	"nome_trabalhador_id" INT NOT NULL,
	"especialidade_marcacao" VARCHAR(25) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("id"),
	FOREIGN KEY INDEX "FK__marcações__nome___151B244E" ("nome_cliente_id"),
	FOREIGN KEY INDEX "FK__marcacao_especialidade" ("especialidade_marcacao"),
	FOREIGN KEY INDEX "FK__marcações__nome___160F4887" ("nome_trabalhador_id"),
	CONSTRAINT "FK__marcações__nome___160F4887" FOREIGN KEY ("nome_trabalhador_id") REFERENCES "trabalhadores" ("id") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__marcações__nome___151B244E" FOREIGN KEY ("nome_cliente_id") REFERENCES "cliente" ("id") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__marcacao_especialidade" FOREIGN KEY ("especialidade_marcacao") REFERENCES "especialidade_tabela" ("especialidade") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.marcacoes_cliente: -1 rows
DELETE FROM "marcacoes_cliente";
/*!40000 ALTER TABLE "marcacoes_cliente" DISABLE KEYS */;
INSERT INTO "marcacoes_cliente" ("id", "dia_marcacao", "hora", "nome_cliente_id", "nome_trabalhador_id", "especialidade_marcacao") VALUES
	(73, '2022-06-28', '19:30:00.0000000', 54, 30, 'Manicure');
/*!40000 ALTER TABLE "marcacoes_cliente" ENABLE KEYS */;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.profissao_tabela
DROP TABLE IF EXISTS "profissao_tabela";
CREATE TABLE IF NOT EXISTS "profissao_tabela" (
	"id_profissao" INT NOT NULL,
	"profissao" VARCHAR(10) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("id_profissao")
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.profissao_tabela: -1 rows
DELETE FROM "profissao_tabela";
/*!40000 ALTER TABLE "profissao_tabela" DISABLE KEYS */;
INSERT INTO "profissao_tabela" ("id_profissao", "profissao") VALUES
	(1, 'Médico'),
	(3, 'Estética');
/*!40000 ALTER TABLE "profissao_tabela" ENABLE KEYS */;

-- Dumping structure for procedure PSI20L_DavidDoroshev_2220080.sp_alterdiagram
DROP PROCEDURE IF EXISTS "sp_alterdiagram";
DELIMITER //

	CREATE PROCEDURE dbo.sp_alterdiagram
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
	//
DELIMITER ;

-- Dumping structure for procedure PSI20L_DavidDoroshev_2220080.sp_creatediagram
DROP PROCEDURE IF EXISTS "sp_creatediagram";
DELIMITER //

	CREATE PROCEDURE dbo.sp_creatediagram
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
	//
DELIMITER ;

-- Dumping structure for procedure PSI20L_DavidDoroshev_2220080.sp_dropdiagram
DROP PROCEDURE IF EXISTS "sp_dropdiagram";
DELIMITER //

	CREATE PROCEDURE dbo.sp_dropdiagram
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
	//
DELIMITER ;

-- Dumping structure for procedure PSI20L_DavidDoroshev_2220080.sp_helpdiagramdefinition
DROP PROCEDURE IF EXISTS "sp_helpdiagramdefinition";
DELIMITER //

	CREATE PROCEDURE dbo.sp_helpdiagramdefinition
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
	//
DELIMITER ;

-- Dumping structure for procedure PSI20L_DavidDoroshev_2220080.sp_helpdiagrams
DROP PROCEDURE IF EXISTS "sp_helpdiagrams";
DELIMITER //

	CREATE PROCEDURE dbo.sp_helpdiagrams
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
	//
DELIMITER ;

-- Dumping structure for procedure PSI20L_DavidDoroshev_2220080.sp_renamediagram
DROP PROCEDURE IF EXISTS "sp_renamediagram";
DELIMITER //

	CREATE PROCEDURE dbo.sp_renamediagram
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
	//
DELIMITER ;

-- Dumping structure for procedure PSI20L_DavidDoroshev_2220080.sp_upgraddiagrams
DROP PROCEDURE IF EXISTS "sp_upgraddiagrams";
DELIMITER //

	CREATE PROCEDURE dbo.sp_upgraddiagrams
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
	//
DELIMITER ;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.sysdiagrams
DROP TABLE IF EXISTS "sysdiagrams";
CREATE TABLE IF NOT EXISTS "sysdiagrams" (
	"name" NVARCHAR(128) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"principal_id" INT NOT NULL,
	"diagram_id" INT NOT NULL,
	"version" INT NULL DEFAULT NULL,
	"definition" VARBINARY NULL DEFAULT NULL,
	PRIMARY KEY ("diagram_id"),
	UNIQUE INDEX "UK_principal_name" ("name", "principal_id")
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.sysdiagrams: -1 rows
DELETE FROM "sysdiagrams";
/*!40000 ALTER TABLE "sysdiagrams" DISABLE KEYS */;
/*!40000 ALTER TABLE "sysdiagrams" ENABLE KEYS */;

-- Dumping structure for table PSI20L_DavidDoroshev_2220080.trabalhadores
DROP TABLE IF EXISTS "trabalhadores";
CREATE TABLE IF NOT EXISTS "trabalhadores" (
	"id" INT NOT NULL,
	"nome" VARCHAR(25) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"password" VARCHAR(25) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"codigo_postal_trabalhador" VARCHAR(8) NOT NULL COLLATE 'Latin1_General_CI_AI',
	"especialidade_tabela_trabalhador" VARCHAR(25) NOT NULL COLLATE 'Latin1_General_CI_AI',
	PRIMARY KEY ("id"),
	FOREIGN KEY INDEX "FK__trabalhad__codig__59063A47" ("codigo_postal_trabalhador"),
	FOREIGN KEY INDEX "FK__trabalhad__espec__75A278F5" ("especialidade_tabela_trabalhador"),
	CONSTRAINT "FK__trabalhad__codig__59063A47" FOREIGN KEY ("codigo_postal_trabalhador") REFERENCES "codigo_postal" ("codigo_postal") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK__trabalhad__espec__75A278F5" FOREIGN KEY ("especialidade_tabela_trabalhador") REFERENCES "especialidade_tabela" ("especialidade") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Dumping data for table PSI20L_DavidDoroshev_2220080.trabalhadores: -1 rows
DELETE FROM "trabalhadores";
/*!40000 ALTER TABLE "trabalhadores" DISABLE KEYS */;
INSERT INTO "trabalhadores" ("id", "nome", "password", "codigo_postal_trabalhador", "especialidade_tabela_trabalhador") VALUES
	(30, 'Carlos', 'Teste6172', '2820-495', 'Manicure'),
	(32, 'Hugo', 'Mugh33122', '1675-017', 'Cardiologia');
/*!40000 ALTER TABLE "trabalhadores" ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
