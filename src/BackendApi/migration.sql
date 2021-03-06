IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Component] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [HtmlContent] nvarchar(max) NULL,
    [CreatedBy] uniqueidentifier NOT NULL,
    [CreatedOn] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    [ModifiedBy] uniqueidentifier NOT NULL,
    [ModifiedOn] datetime2 NOT NULL,
    CONSTRAINT [PK_Component] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Member] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [CreatedBy] uniqueidentifier NOT NULL,
    [CreatedOn] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    [ModifiedBy] uniqueidentifier NOT NULL,
    [ModifiedOn] datetime2 NOT NULL,
    CONSTRAINT [PK_Member] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Page] (
    [Id] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Route] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [RawHtml] nvarchar(max) NULL,
    [CsRegions] nvarchar(max) NULL,
    [CreatedBy] uniqueidentifier NOT NULL,
    [CreatedOn] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    [ModifiedBy] uniqueidentifier NOT NULL,
    [ModifiedOn] datetime2 NOT NULL,
    CONSTRAINT [PK_Page] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [TestModel] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [CreatedBy] uniqueidentifier NOT NULL,
    [CreatedOn] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    [ModifiedBy] uniqueidentifier NOT NULL,
    [ModifiedOn] datetime2 NOT NULL,
    CONSTRAINT [PK_TestModel] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(450) NOT NULL,
    [ProviderKey] nvarchar(450) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(450) NOT NULL,
    [Name] nvarchar(450) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [Section] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [RegionId] nvarchar(max) NULL,
    [ClassName] nvarchar(max) NULL,
    [HtmlContent] nvarchar(max) NULL,
    [CreatedBy] uniqueidentifier NOT NULL,
    [CreatedOn] datetime2 NOT NULL,
    [IsDeleted] bit NOT NULL,
    [ModifiedBy] uniqueidentifier NOT NULL,
    [ModifiedOn] datetime2 NOT NULL,
    [PageId] int NULL,
    CONSTRAINT [PK_Section] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Section_Page_PageId] FOREIGN KEY ([PageId]) REFERENCES [Page] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

CREATE INDEX [IX_Section_PageId] ON [Section] ([PageId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200308135229_initial', N'3.1.2');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200309151550_adding navigation tree table', N'3.1.2');

GO


