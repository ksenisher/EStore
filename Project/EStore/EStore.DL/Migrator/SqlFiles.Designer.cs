﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EStore.DL.Migrator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SqlFiles {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlFiles() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EStore.DL.Migrator.SqlFiles", typeof(SqlFiles).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  Table [dbo].[tblUser]    Script Date: 02/07/2016 19:59:15 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///CREATE TABLE [dbo].[tblUser](
        ///	[Id] [bigint] IDENTITY(1,1) NOT NULL,
        ///	[FirstName] [nvarchar](250) NULL,
        ///	[LastName] [nvarchar](250) NULL,
        ///	[UserName] [nvarchar](250) NULL,
        ///	[Password] [nvarchar](250) NULL,
        /// CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
        ///(
        ///	[Id] ASC
        ///)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, AL [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _20150207_update {
            get {
                return ResourceManager.GetString("_20150207_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  Table [dbo].[tblFile]    Script Date: 02/29/2016 00:02:38 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///CREATE TABLE [dbo].[tblFile](
        ///	[Id] [bigint] IDENTITY(1,1) NOT NULL,
        ///	[Path] [nvarchar](250) NULL,
        ///	[Description] [nvarchar](250) NULL,
        ///	[ProductId] [bigint] NULL,
        /// CONSTRAINT [PK_tblFile] PRIMARY KEY CLUSTERED 
        ///(
        ///	[Id] ASC
        ///)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
        ///) ON [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _20150228_update {
            get {
                return ResourceManager.GetString("_20150228_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblUser ADD Email [nvarchar](250) NULL
        ///GO
        ///
        ///ALTER TABLE tblProduct ADD ManufacterId [bigint] NULL
        ///GO
        ///
        ////****** Object:  Table [dbo].[tblManufacter]    Script Date: 03/18/2016 00:53:00 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///CREATE TABLE [dbo].[tblManufacter](
        ///	[Id] [bigint] NOT NULL,
        ///	[Name] [nvarchar](250) NULL,
        /// CONSTRAINT [PK_tblManufacter] PRIMARY KEY CLUSTERED 
        ///(
        ///	[Id] ASC
        ///)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _20150318_update {
            get {
                return ResourceManager.GetString("_20150318_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblFile ADD SupplierInvoiceId [bigint] NULL
        ///GO
        ///
        ///ALTER TABLE tblSupplierInvoice ADD SupplierId [bigint] NULL
        ///GO
        ///
        ///ALTER TABLE tblSupplierInvoicePosition DROP CONSTRAINT FK_tblSupplierInvoicePosition_tblSupplier
        ///
        ////****** Object:  ForeignKey [FK_tblFile_tblSupplierInvoice]    Script Date: 03/19/2016 18:17:39 ******/
        ///ALTER TABLE [dbo].[tblFile]  WITH CHECK ADD  CONSTRAINT [FK_tblFile_tblSupplierInvoice] FOREIGN KEY([SupplierInvoiceId])
        ///REFERENCES [dbo].[tblSupplierInvoice] ([Id])
        ///GO
        ///ALTER [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _20150319_update {
            get {
                return ResourceManager.GetString("_20150319_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblFile ADD Position decimal(18, 2) NULL
        ///GO
        ///.
        /// </summary>
        public static string _20150327_update {
            get {
                return ResourceManager.GetString("_20150327_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblProductSingle DROP COLUMN IsSelling
        ///ALTER TABLE tblProductSingle ADD [State] int NULL
        ///GO
        ///.
        /// </summary>
        public static string _20150327_update_2 {
            get {
                return ResourceManager.GetString("_20150327_update_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblProductSingle ADD SupplierInvoicePositionId bigint NULL
        ///GO
        ///
        ///ALTER TABLE tblProductSingle ADD SupplierInvoiceId bigint NULL
        ///GO
        ///
        ////****** Object:  ForeignKey [FK_tblProductSingle_tblSupplierInvoice]    Script Date: 03/27/2016 20:59:48 ******/
        ///ALTER TABLE [dbo].[tblProductSingle]  WITH CHECK ADD  CONSTRAINT [FK_tblProductSingle_tblSupplierInvoice] FOREIGN KEY([SupplierInvoiceId])
        ///REFERENCES [dbo].[tblSupplierInvoice] ([Id])
        ///GO
        ///ALTER TABLE [dbo].[tblProductSingle] CHECK CONSTRAINT [FK_tb [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _20150327_update_3 {
            get {
                return ResourceManager.GetString("_20150327_update_3", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblProductSingle ADD Notes nvarchar(MAX) NULL
        ///GO
        ///.
        /// </summary>
        public static string _20150327_update_4 {
            get {
                return ResourceManager.GetString("_20150327_update_4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblProductSingle ALTER COLUMN IsNew BIT NULL
        ///GO 
        ///.
        /// </summary>
        public static string _20150328_update {
            get {
                return ResourceManager.GetString("_20150328_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblProduct ADD CategoryId bigint NULL
        ///GO
        ///
        ////****** Object:  Table [dbo].[tblProductCategory]    Script Date: 03/29/2016 00:12:16 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///CREATE TABLE [dbo].[tblProductCategory](
        ///	[Id] [bigint] IDENTITY(1,1) NOT NULL,
        ///	[Name] [nvarchar](250) NULL,
        ///	[ParentCategoryId] [bigint] NULL,
        /// CONSTRAINT [PK_tblProductCategory] PRIMARY KEY CLUSTERED 
        ///(
        ///	[Id] ASC
        ///)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _20150329_update {
            get {
                return ResourceManager.GetString("_20150329_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblUser ADD IsAdmin bit NULL
        ///GO
        ///.
        /// </summary>
        public static string _20150330_update {
            get {
                return ResourceManager.GetString("_20150330_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /****** Object:  Table [dbo].[tblProductFeedback]    Script Date: 04/04/2016 02:24:01 ******/
        ///SET ANSI_NULLS ON
        ///GO
        ///SET QUOTED_IDENTIFIER ON
        ///GO
        ///CREATE TABLE [dbo].[tblProductFeedback](
        ///	[Id] [bigint] IDENTITY(1,1) NOT NULL,
        ///	[Pluses] [nvarchar](max) NULL,
        ///	[Minuses] [nvarchar](max) NULL,
        ///	[Comment] [nvarchar](max) NULL,
        ///	[Stars] [int] NULL,
        ///	[UserName] [nvarchar](250) NULL,
        ///	[ProductId] [bigint] NULL,
        /// CONSTRAINT [PK_tblProductFeedback] PRIMARY KEY CLUSTERED 
        ///(
        ///	[Id] ASC
        ///)WITH (PAD_INDEX  = O [rest of string was truncated]&quot;;.
        /// </summary>
        public static string _20150404_update {
            get {
                return ResourceManager.GetString("_20150404_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblProduct ADD Specs nvarchar(MAX) NULL
        ///GO
        ///.
        /// </summary>
        public static string _20150503_update {
            get {
                return ResourceManager.GetString("_20150503_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblProduct ADD YandexUrl nvarchar(250) NULL
        ///GO
        ///.
        /// </summary>
        public static string _20150503_update_2 {
            get {
                return ResourceManager.GetString("_20150503_update_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ALTER TABLE tblOrder ADD IsDelivery bit NULL
        ///ALTER TABLE tblOrder ADD City nvarchar(255) NULL
        ///ALTER TABLE tblOrder ADD Address nvarchar(255) NULL
        ///ALTER TABLE tblOrder ADD Name nvarchar(255) NULL
        ///ALTER TABLE tblOrder ADD Phone nvarchar(255) NULL
        ///ALTER TABLE tblOrder ADD Email nvarchar(255) NULL
        ///GO
        ///.
        /// </summary>
        public static string _20150522_update {
            get {
                return ResourceManager.GetString("_20150522_update", resourceCulture);
            }
        }
    }
}
