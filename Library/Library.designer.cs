﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="library")]
	public partial class LibraryDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertauthors(authors instance);
    partial void Updateauthors(authors instance);
    partial void Deleteauthors(authors instance);
    partial void Insertbooks(books instance);
    partial void Updatebooks(books instance);
    partial void Deletebooks(books instance);
    partial void Insertborrows(borrows instance);
    partial void Updateborrows(borrows instance);
    partial void Deleteborrows(borrows instance);
    partial void Insertstudents(students instance);
    partial void Updatestudents(students instance);
    partial void Deletestudents(students instance);
    partial void Inserttypes(types instance);
    partial void Updatetypes(types instance);
    partial void Deletetypes(types instance);
    #endregion
		
		public LibraryDataContext() : 
				base(global::Library.Properties.Settings.Default.libraryConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LibraryDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<authors> authors
		{
			get
			{
				return this.GetTable<authors>();
			}
		}
		
		public System.Data.Linq.Table<books> books
		{
			get
			{
				return this.GetTable<books>();
			}
		}
		
		public System.Data.Linq.Table<borrows> borrows
		{
			get
			{
				return this.GetTable<borrows>();
			}
		}
		
		public System.Data.Linq.Table<students> students
		{
			get
			{
				return this.GetTable<students>();
			}
		}
		
		public System.Data.Linq.Table<types> types
		{
			get
			{
				return this.GetTable<types>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.authors")]
	public partial class authors : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _authorId;
		
		private string _name;
		
		private string _surname;
		
		private EntitySet<books> _books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnauthorIdChanging(int value);
    partial void OnauthorIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsurnameChanging(string value);
    partial void OnsurnameChanged();
    #endregion
		
		public authors()
		{
			this._books = new EntitySet<books>(new Action<books>(this.attach_books), new Action<books>(this.detach_books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int authorId
		{
			get
			{
				return this._authorId;
			}
			set
			{
				if ((this._authorId != value))
				{
					this.OnauthorIdChanging(value);
					this.SendPropertyChanging();
					this._authorId = value;
					this.SendPropertyChanged("authorId");
					this.OnauthorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surname", DbType="VarChar(70)")]
		public string surname
		{
			get
			{
				return this._surname;
			}
			set
			{
				if ((this._surname != value))
				{
					this.OnsurnameChanging(value);
					this.SendPropertyChanging();
					this._surname = value;
					this.SendPropertyChanged("surname");
					this.OnsurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="authors_books", Storage="_books", ThisKey="authorId", OtherKey="authorId")]
		public EntitySet<books> books
		{
			get
			{
				return this._books;
			}
			set
			{
				this._books.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_books(books entity)
		{
			this.SendPropertyChanging();
			entity.authors = this;
		}
		
		private void detach_books(books entity)
		{
			this.SendPropertyChanging();
			entity.authors = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.books")]
	public partial class books : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _bookId;
		
		private string _name;
		
		private System.Nullable<int> _pagecount;
		
		private System.Nullable<int> _point;
		
		private System.Nullable<int> _authorId;
		
		private System.Nullable<int> _typeId;
		
		private EntitySet<borrows> _borrows;
		
		private EntityRef<authors> _authors;
		
		private EntityRef<types> _types;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnbookIdChanging(int value);
    partial void OnbookIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnpagecountChanging(System.Nullable<int> value);
    partial void OnpagecountChanged();
    partial void OnpointChanging(System.Nullable<int> value);
    partial void OnpointChanged();
    partial void OnauthorIdChanging(System.Nullable<int> value);
    partial void OnauthorIdChanged();
    partial void OntypeIdChanging(System.Nullable<int> value);
    partial void OntypeIdChanged();
    #endregion
		
		public books()
		{
			this._borrows = new EntitySet<borrows>(new Action<borrows>(this.attach_borrows), new Action<borrows>(this.detach_borrows));
			this._authors = default(EntityRef<authors>);
			this._types = default(EntityRef<types>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int bookId
		{
			get
			{
				return this._bookId;
			}
			set
			{
				if ((this._bookId != value))
				{
					this.OnbookIdChanging(value);
					this.SendPropertyChanging();
					this._bookId = value;
					this.SendPropertyChanged("bookId");
					this.OnbookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(90)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pagecount", DbType="Int")]
		public System.Nullable<int> pagecount
		{
			get
			{
				return this._pagecount;
			}
			set
			{
				if ((this._pagecount != value))
				{
					this.OnpagecountChanging(value);
					this.SendPropertyChanging();
					this._pagecount = value;
					this.SendPropertyChanged("pagecount");
					this.OnpagecountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point", DbType="Int")]
		public System.Nullable<int> point
		{
			get
			{
				return this._point;
			}
			set
			{
				if ((this._point != value))
				{
					this.OnpointChanging(value);
					this.SendPropertyChanging();
					this._point = value;
					this.SendPropertyChanged("point");
					this.OnpointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_authorId", DbType="Int")]
		public System.Nullable<int> authorId
		{
			get
			{
				return this._authorId;
			}
			set
			{
				if ((this._authorId != value))
				{
					if (this._authors.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnauthorIdChanging(value);
					this.SendPropertyChanging();
					this._authorId = value;
					this.SendPropertyChanged("authorId");
					this.OnauthorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeId", DbType="Int")]
		public System.Nullable<int> typeId
		{
			get
			{
				return this._typeId;
			}
			set
			{
				if ((this._typeId != value))
				{
					if (this._types.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OntypeIdChanging(value);
					this.SendPropertyChanging();
					this._typeId = value;
					this.SendPropertyChanged("typeId");
					this.OntypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="books_borrows", Storage="_borrows", ThisKey="bookId", OtherKey="bookId")]
		public EntitySet<borrows> borrows
		{
			get
			{
				return this._borrows;
			}
			set
			{
				this._borrows.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="authors_books", Storage="_authors", ThisKey="authorId", OtherKey="authorId", IsForeignKey=true)]
		public authors authors
		{
			get
			{
				return this._authors.Entity;
			}
			set
			{
				authors previousValue = this._authors.Entity;
				if (((previousValue != value) 
							|| (this._authors.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._authors.Entity = null;
						previousValue.books.Remove(this);
					}
					this._authors.Entity = value;
					if ((value != null))
					{
						value.books.Add(this);
						this._authorId = value.authorId;
					}
					else
					{
						this._authorId = default(Nullable<int>);
					}
					this.SendPropertyChanged("authors");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="types_books", Storage="_types", ThisKey="typeId", OtherKey="typeId", IsForeignKey=true)]
		public types types
		{
			get
			{
				return this._types.Entity;
			}
			set
			{
				types previousValue = this._types.Entity;
				if (((previousValue != value) 
							|| (this._types.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._types.Entity = null;
						previousValue.books.Remove(this);
					}
					this._types.Entity = value;
					if ((value != null))
					{
						value.books.Add(this);
						this._typeId = value.typeId;
					}
					else
					{
						this._typeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("types");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_borrows(borrows entity)
		{
			this.SendPropertyChanging();
			entity.books = this;
		}
		
		private void detach_borrows(borrows entity)
		{
			this.SendPropertyChanging();
			entity.books = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.borrows")]
	public partial class borrows : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _borrowId;
		
		private System.Nullable<int> _studentId;
		
		private System.Nullable<int> _bookId;
		
		private System.Nullable<System.DateTime> _takenDate;
		
		private System.Nullable<System.DateTime> _broughtDate;
		
		private EntityRef<books> _books;
		
		private EntityRef<students> _students;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnborrowIdChanging(int value);
    partial void OnborrowIdChanged();
    partial void OnstudentIdChanging(System.Nullable<int> value);
    partial void OnstudentIdChanged();
    partial void OnbookIdChanging(System.Nullable<int> value);
    partial void OnbookIdChanged();
    partial void OntakenDateChanging(System.Nullable<System.DateTime> value);
    partial void OntakenDateChanged();
    partial void OnbroughtDateChanging(System.Nullable<System.DateTime> value);
    partial void OnbroughtDateChanged();
    #endregion
		
		public borrows()
		{
			this._books = default(EntityRef<books>);
			this._students = default(EntityRef<students>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_borrowId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int borrowId
		{
			get
			{
				return this._borrowId;
			}
			set
			{
				if ((this._borrowId != value))
				{
					this.OnborrowIdChanging(value);
					this.SendPropertyChanging();
					this._borrowId = value;
					this.SendPropertyChanged("borrowId");
					this.OnborrowIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentId", DbType="Int")]
		public System.Nullable<int> studentId
		{
			get
			{
				return this._studentId;
			}
			set
			{
				if ((this._studentId != value))
				{
					if (this._students.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnstudentIdChanging(value);
					this.SendPropertyChanging();
					this._studentId = value;
					this.SendPropertyChanged("studentId");
					this.OnstudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookId", DbType="Int")]
		public System.Nullable<int> bookId
		{
			get
			{
				return this._bookId;
			}
			set
			{
				if ((this._bookId != value))
				{
					if (this._books.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnbookIdChanging(value);
					this.SendPropertyChanging();
					this._bookId = value;
					this.SendPropertyChanged("bookId");
					this.OnbookIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_takenDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> takenDate
		{
			get
			{
				return this._takenDate;
			}
			set
			{
				if ((this._takenDate != value))
				{
					this.OntakenDateChanging(value);
					this.SendPropertyChanging();
					this._takenDate = value;
					this.SendPropertyChanged("takenDate");
					this.OntakenDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_broughtDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> broughtDate
		{
			get
			{
				return this._broughtDate;
			}
			set
			{
				if ((this._broughtDate != value))
				{
					this.OnbroughtDateChanging(value);
					this.SendPropertyChanging();
					this._broughtDate = value;
					this.SendPropertyChanged("broughtDate");
					this.OnbroughtDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="books_borrows", Storage="_books", ThisKey="bookId", OtherKey="bookId", IsForeignKey=true)]
		public books books
		{
			get
			{
				return this._books.Entity;
			}
			set
			{
				books previousValue = this._books.Entity;
				if (((previousValue != value) 
							|| (this._books.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._books.Entity = null;
						previousValue.borrows.Remove(this);
					}
					this._books.Entity = value;
					if ((value != null))
					{
						value.borrows.Add(this);
						this._bookId = value.bookId;
					}
					else
					{
						this._bookId = default(Nullable<int>);
					}
					this.SendPropertyChanged("books");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="students_borrows", Storage="_students", ThisKey="studentId", OtherKey="studentId", IsForeignKey=true)]
		public students students
		{
			get
			{
				return this._students.Entity;
			}
			set
			{
				students previousValue = this._students.Entity;
				if (((previousValue != value) 
							|| (this._students.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._students.Entity = null;
						previousValue.borrows.Remove(this);
					}
					this._students.Entity = value;
					if ((value != null))
					{
						value.borrows.Add(this);
						this._studentId = value.studentId;
					}
					else
					{
						this._studentId = default(Nullable<int>);
					}
					this.SendPropertyChanged("students");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.students")]
	public partial class students : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _studentId;
		
		private string _name;
		
		private string _surname;
		
		private System.Nullable<System.DateTime> _birthdate;
		
		private string _gender;
		
		private string _class;
		
		private System.Nullable<int> _point;
		
		private EntitySet<borrows> _borrows;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnstudentIdChanging(int value);
    partial void OnstudentIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnsurnameChanging(string value);
    partial void OnsurnameChanged();
    partial void OnbirthdateChanging(System.Nullable<System.DateTime> value);
    partial void OnbirthdateChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnclassChanging(string value);
    partial void OnclassChanged();
    partial void OnpointChanging(System.Nullable<int> value);
    partial void OnpointChanged();
    #endregion
		
		public students()
		{
			this._borrows = new EntitySet<borrows>(new Action<borrows>(this.attach_borrows), new Action<borrows>(this.detach_borrows));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_studentId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int studentId
		{
			get
			{
				return this._studentId;
			}
			set
			{
				if ((this._studentId != value))
				{
					this.OnstudentIdChanging(value);
					this.SendPropertyChanging();
					this._studentId = value;
					this.SendPropertyChanged("studentId");
					this.OnstudentIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(20)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_surname", DbType="VarChar(20)")]
		public string surname
		{
			get
			{
				return this._surname;
			}
			set
			{
				if ((this._surname != value))
				{
					this.OnsurnameChanging(value);
					this.SendPropertyChanging();
					this._surname = value;
					this.SendPropertyChanged("surname");
					this.OnsurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_birthdate", DbType="Date")]
		public System.Nullable<System.DateTime> birthdate
		{
			get
			{
				return this._birthdate;
			}
			set
			{
				if ((this._birthdate != value))
				{
					this.OnbirthdateChanging(value);
					this.SendPropertyChanging();
					this._birthdate = value;
					this.SendPropertyChanged("birthdate");
					this.OnbirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(10)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="class", Storage="_class", DbType="VarChar(7)")]
		public string @class
		{
			get
			{
				return this._class;
			}
			set
			{
				if ((this._class != value))
				{
					this.OnclassChanging(value);
					this.SendPropertyChanging();
					this._class = value;
					this.SendPropertyChanged("@class");
					this.OnclassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_point", DbType="Int")]
		public System.Nullable<int> point
		{
			get
			{
				return this._point;
			}
			set
			{
				if ((this._point != value))
				{
					this.OnpointChanging(value);
					this.SendPropertyChanging();
					this._point = value;
					this.SendPropertyChanged("point");
					this.OnpointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="students_borrows", Storage="_borrows", ThisKey="studentId", OtherKey="studentId")]
		public EntitySet<borrows> borrows
		{
			get
			{
				return this._borrows;
			}
			set
			{
				this._borrows.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_borrows(borrows entity)
		{
			this.SendPropertyChanging();
			entity.students = this;
		}
		
		private void detach_borrows(borrows entity)
		{
			this.SendPropertyChanging();
			entity.students = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.types")]
	public partial class types : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _typeId;
		
		private string _name;
		
		private EntitySet<books> _books;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntypeIdChanging(int value);
    partial void OntypeIdChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    #endregion
		
		public types()
		{
			this._books = new EntitySet<books>(new Action<books>(this.attach_books), new Action<books>(this.detach_books));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_typeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int typeId
		{
			get
			{
				return this._typeId;
			}
			set
			{
				if ((this._typeId != value))
				{
					this.OntypeIdChanging(value);
					this.SendPropertyChanging();
					this._typeId = value;
					this.SendPropertyChanged("typeId");
					this.OntypeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(30)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="types_books", Storage="_books", ThisKey="typeId", OtherKey="typeId")]
		public EntitySet<books> books
		{
			get
			{
				return this._books;
			}
			set
			{
				this._books.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_books(books entity)
		{
			this.SendPropertyChanging();
			entity.types = this;
		}
		
		private void detach_books(books entity)
		{
			this.SendPropertyChanging();
			entity.types = null;
		}
	}
}
#pragma warning restore 1591
