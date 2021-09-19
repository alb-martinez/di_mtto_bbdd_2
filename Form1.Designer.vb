<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim FechaNacLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim IdAsigLabel As System.Windows.Forms.Label
        Dim AsignaturaLabel As System.Windows.Forms.Label
        Dim IdMatriculaLabel As System.Windows.Forms.Label
        Dim IdAlumnoLabel As System.Windows.Forms.Label
        Dim IdAsigLabel1 As System.Windows.Forms.Label
        Dim FechaMatriculaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EscuelaDataSet = New MttoBD2.escuelaDataSet()
        Me.AlumnosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlumnosTableAdapter = New MttoBD2.escuelaDataSetTableAdapters.alumnosTableAdapter()
        Me.TableAdapterManager = New MttoBD2.escuelaDataSetTableAdapters.TableAdapterManager()
        Me.AlumnosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AlumnosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlumnosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.FechaNacTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.AsignaturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsignaturasTableAdapter = New MttoBD2.escuelaDataSetTableAdapters.asignaturasTableAdapter()
        Me.AsignaturasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAsigTextBox = New System.Windows.Forms.TextBox()
        Me.AsignaturaTextBox = New System.Windows.Forms.TextBox()
        Me.AsignaturasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AsignaturasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MatriculasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatriculasTableAdapter = New MttoBD2.escuelaDataSetTableAdapters.matriculaTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdMatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAlumnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdAsigDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaMatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MatriculasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MatriculasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdMatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.IdAlumnoTextBox = New System.Windows.Forms.TextBox()
        Me.IdAsigTextBox1 = New System.Windows.Forms.TextBox()
        Me.FechaMatriculaTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        FechaNacLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        IdAsigLabel = New System.Windows.Forms.Label()
        AsignaturaLabel = New System.Windows.Forms.Label()
        IdMatriculaLabel = New System.Windows.Forms.Label()
        IdAlumnoLabel = New System.Windows.Forms.Label()
        IdAsigLabel1 = New System.Windows.Forms.Label()
        FechaMatriculaLabel = New System.Windows.Forms.Label()
        CType(Me.EscuelaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlumnosBindingNavigator.SuspendLayout()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsignaturasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AsignaturasBindingNavigator.SuspendLayout()
        CType(Me.MatriculasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatriculasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MatriculasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(820, 49)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(35, 23)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(820, 82)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(95, 23)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.Location = New System.Drawing.Point(820, 114)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(107, 23)
        ApellidosLabel.TabIndex = 6
        ApellidosLabel.Text = "Apellidos:"
        '
        'FechaNacLabel
        '
        FechaNacLabel.AutoSize = True
        FechaNacLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaNacLabel.Location = New System.Drawing.Point(820, 146)
        FechaNacLabel.Name = "FechaNacLabel"
        FechaNacLabel.Size = New System.Drawing.Size(124, 23)
        FechaNacLabel.TabIndex = 8
        FechaNacLabel.Text = "Fecha Nac:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProvinciaLabel.Location = New System.Drawing.Point(820, 177)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(105, 23)
        ProvinciaLabel.TabIndex = 10
        ProvinciaLabel.Text = "Provincia:"
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EdadLabel.Location = New System.Drawing.Point(820, 209)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(65, 23)
        EdadLabel.TabIndex = 12
        EdadLabel.Text = "Edad:"
        '
        'IdAsigLabel
        '
        IdAsigLabel.AutoSize = True
        IdAsigLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdAsigLabel.Location = New System.Drawing.Point(820, 326)
        IdAsigLabel.Name = "IdAsigLabel"
        IdAsigLabel.Size = New System.Drawing.Size(83, 23)
        IdAsigLabel.TabIndex = 15
        IdAsigLabel.Text = "Id Asig:"
        '
        'AsignaturaLabel
        '
        AsignaturaLabel.AutoSize = True
        AsignaturaLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AsignaturaLabel.Location = New System.Drawing.Point(820, 358)
        AsignaturaLabel.Name = "AsignaturaLabel"
        AsignaturaLabel.Size = New System.Drawing.Size(120, 23)
        AsignaturaLabel.TabIndex = 17
        AsignaturaLabel.Text = "Asignatura:"
        '
        'IdMatriculaLabel
        '
        IdMatriculaLabel.AutoSize = True
        IdMatriculaLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdMatriculaLabel.Location = New System.Drawing.Point(820, 643)
        IdMatriculaLabel.Name = "IdMatriculaLabel"
        IdMatriculaLabel.Size = New System.Drawing.Size(132, 23)
        IdMatriculaLabel.TabIndex = 22
        IdMatriculaLabel.Text = "Id Matricula:"
        '
        'IdAlumnoLabel
        '
        IdAlumnoLabel.AutoSize = True
        IdAlumnoLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdAlumnoLabel.Location = New System.Drawing.Point(820, 675)
        IdAlumnoLabel.Name = "IdAlumnoLabel"
        IdAlumnoLabel.Size = New System.Drawing.Size(117, 23)
        IdAlumnoLabel.TabIndex = 24
        IdAlumnoLabel.Text = "Id Alumno:"
        '
        'IdAsigLabel1
        '
        IdAsigLabel1.AutoSize = True
        IdAsigLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdAsigLabel1.Location = New System.Drawing.Point(820, 708)
        IdAsigLabel1.Name = "IdAsigLabel1"
        IdAsigLabel1.Size = New System.Drawing.Size(83, 23)
        IdAsigLabel1.TabIndex = 26
        IdAsigLabel1.Text = "Id Asig:"
        '
        'FechaMatriculaLabel
        '
        FechaMatriculaLabel.AutoSize = True
        FechaMatriculaLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaMatriculaLabel.Location = New System.Drawing.Point(820, 738)
        FechaMatriculaLabel.Name = "FechaMatriculaLabel"
        FechaMatriculaLabel.Size = New System.Drawing.Size(174, 23)
        FechaMatriculaLabel.TabIndex = 28
        FechaMatriculaLabel.Text = "Fecha Matricula:"
        '
        'EscuelaDataSet
        '
        Me.EscuelaDataSet.DataSetName = "escuelaDataSet"
        Me.EscuelaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlumnosBindingSource
        '
        Me.AlumnosBindingSource.DataMember = "alumnos"
        Me.AlumnosBindingSource.DataSource = Me.EscuelaDataSet
        '
        'AlumnosTableAdapter
        '
        Me.AlumnosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alumnosTableAdapter = Me.AlumnosTableAdapter
        Me.TableAdapterManager.asignaturasTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.matriculaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MttoBD2.escuelaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlumnosBindingNavigator
        '
        Me.AlumnosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AlumnosBindingNavigator.BindingSource = Me.AlumnosBindingSource1
        Me.AlumnosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AlumnosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AlumnosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.AlumnosBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.AlumnosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AlumnosBindingNavigatorSaveItem})
        Me.AlumnosBindingNavigator.Location = New System.Drawing.Point(12, 235)
        Me.AlumnosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AlumnosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AlumnosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AlumnosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AlumnosBindingNavigator.Name = "AlumnosBindingNavigator"
        Me.AlumnosBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.AlumnosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AlumnosBindingNavigator.Size = New System.Drawing.Size(386, 33)
        Me.AlumnosBindingNavigator.TabIndex = 0
        Me.AlumnosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'AlumnosBindingSource1
        '
        Me.AlumnosBindingSource1.DataMember = "alumnos"
        Me.AlumnosBindingSource1.DataSource = Me.EscuelaDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'AlumnosBindingNavigatorSaveItem
        '
        Me.AlumnosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlumnosBindingNavigatorSaveItem.Image = CType(resources.GetObject("AlumnosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AlumnosBindingNavigatorSaveItem.Name = "AlumnosBindingNavigatorSaveItem"
        Me.AlumnosBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.AlumnosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidosDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.ProvinciaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnosBindingSource1
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(12, 49)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(802, 183)
        Me.DataGridView1.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 59
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 101
        '
        'ApellidosDataGridViewTextBoxColumn
        '
        Me.ApellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos"
        Me.ApellidosDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ApellidosDataGridViewTextBoxColumn.Name = "ApellidosDataGridViewTextBoxColumn"
        Me.ApellidosDataGridViewTextBoxColumn.Width = 109
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "FechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "FechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        Me.FechaNacDataGridViewTextBoxColumn.Width = 118
        '
        'ProvinciaDataGridViewTextBoxColumn
        '
        Me.ProvinciaDataGridViewTextBoxColumn.DataPropertyName = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.ProvinciaDataGridViewTextBoxColumn.Name = "ProvinciaDataGridViewTextBoxColumn"
        Me.ProvinciaDataGridViewTextBoxColumn.Width = 108
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.Width = 83
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource1, "Id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(959, 47)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(172, 30)
        Me.IdTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource1, "Nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(959, 79)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(172, 30)
        Me.NombreTextBox.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource1, "Apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(959, 111)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(172, 30)
        Me.ApellidosTextBox.TabIndex = 7
        '
        'FechaNacTextBox
        '
        Me.FechaNacTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource1, "FechaNac", True))
        Me.FechaNacTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaNacTextBox.Location = New System.Drawing.Point(959, 144)
        Me.FechaNacTextBox.Name = "FechaNacTextBox"
        Me.FechaNacTextBox.Size = New System.Drawing.Size(172, 30)
        Me.FechaNacTextBox.TabIndex = 9
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource1, "Provincia", True))
        Me.ProvinciaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(959, 174)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(172, 30)
        Me.ProvinciaTextBox.TabIndex = 11
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlumnosBindingSource1, "Edad", True))
        Me.EdadTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdadTextBox.Location = New System.Drawing.Point(959, 207)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(172, 30)
        Me.EdadTextBox.TabIndex = 13
        '
        'AsignaturasBindingSource
        '
        Me.AsignaturasBindingSource.DataMember = "asignaturas"
        Me.AsignaturasBindingSource.DataSource = Me.EscuelaDataSet
        '
        'AsignaturasTableAdapter
        '
        Me.AsignaturasTableAdapter.ClearBeforeFill = True
        '
        'AsignaturasDataGridView
        '
        Me.AsignaturasDataGridView.AutoGenerateColumns = False
        Me.AsignaturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AsignaturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.AsignaturasDataGridView.DataSource = Me.AsignaturasBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.AsignaturasDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.AsignaturasDataGridView.Location = New System.Drawing.Point(12, 326)
        Me.AsignaturasDataGridView.Name = "AsignaturasDataGridView"
        Me.AsignaturasDataGridView.RowHeadersWidth = 62
        Me.AsignaturasDataGridView.RowTemplate.Height = 28
        Me.AsignaturasDataGridView.Size = New System.Drawing.Size(802, 220)
        Me.AsignaturasDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdAsig"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdAsig"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Asignatura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Asignatura"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'IdAsigTextBox
        '
        Me.IdAsigTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturasBindingSource, "IdAsig", True))
        Me.IdAsigTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAsigTextBox.Location = New System.Drawing.Point(959, 324)
        Me.IdAsigTextBox.Name = "IdAsigTextBox"
        Me.IdAsigTextBox.Size = New System.Drawing.Size(172, 30)
        Me.IdAsigTextBox.TabIndex = 16
        '
        'AsignaturaTextBox
        '
        Me.AsignaturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AsignaturasBindingSource, "Asignatura", True))
        Me.AsignaturaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AsignaturaTextBox.Location = New System.Drawing.Point(959, 356)
        Me.AsignaturaTextBox.Name = "AsignaturaTextBox"
        Me.AsignaturaTextBox.Size = New System.Drawing.Size(172, 30)
        Me.AsignaturaTextBox.TabIndex = 18
        '
        'AsignaturasBindingNavigator
        '
        Me.AsignaturasBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.AsignaturasBindingNavigator.BindingSource = Me.AsignaturasBindingSource
        Me.AsignaturasBindingNavigator.CountItem = Me.ToolStripLabel1
        Me.AsignaturasBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.AsignaturasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.AsignaturasBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.AsignaturasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.AsignaturasBindingNavigatorSaveItem})
        Me.AsignaturasBindingNavigator.Location = New System.Drawing.Point(12, 563)
        Me.AsignaturasBindingNavigator.MoveFirstItem = Me.ToolStripButton3
        Me.AsignaturasBindingNavigator.MoveLastItem = Me.ToolStripButton6
        Me.AsignaturasBindingNavigator.MoveNextItem = Me.ToolStripButton5
        Me.AsignaturasBindingNavigator.MovePreviousItem = Me.ToolStripButton4
        Me.AsignaturasBindingNavigator.Name = "AsignaturasBindingNavigator"
        Me.AsignaturasBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.AsignaturasBindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.AsignaturasBindingNavigator.Size = New System.Drawing.Size(386, 33)
        Me.AsignaturasBindingNavigator.TabIndex = 19
        Me.AsignaturasBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton1.Text = "Agregar nuevo"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(57, 28)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Número total de elementos"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton2.Text = "Eliminar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton3.Text = "Mover primero"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton4.Text = "Mover anterior"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posición"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 31)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posición actual"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton5.Text = "Mover siguiente"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(34, 28)
        Me.ToolStripButton6.Text = "Mover último"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'AsignaturasBindingNavigatorSaveItem
        '
        Me.AsignaturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AsignaturasBindingNavigatorSaveItem.Image = CType(resources.GetObject("AsignaturasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AsignaturasBindingNavigatorSaveItem.Name = "AsignaturasBindingNavigatorSaveItem"
        Me.AsignaturasBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.AsignaturasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'MatriculasBindingSource
        '
        Me.MatriculasBindingSource.DataMember = "matricula"
        Me.MatriculasBindingSource.DataSource = Me.EscuelaDataSet
        '
        'MatriculasTableAdapter
        '
        Me.MatriculasTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMatriculaDataGridViewTextBoxColumn, Me.IdAlumnoDataGridViewTextBoxColumn, Me.IdAsigDataGridViewTextBoxColumn, Me.FechaMatriculaDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MatriculasBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Location = New System.Drawing.Point(12, 643)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(802, 192)
        Me.DataGridView2.TabIndex = 20
        '
        'IdMatriculaDataGridViewTextBoxColumn
        '
        Me.IdMatriculaDataGridViewTextBoxColumn.DataPropertyName = "IdMatricula"
        Me.IdMatriculaDataGridViewTextBoxColumn.HeaderText = "IdMatricula"
        Me.IdMatriculaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdMatriculaDataGridViewTextBoxColumn.Name = "IdMatriculaDataGridViewTextBoxColumn"
        Me.IdMatriculaDataGridViewTextBoxColumn.Width = 150
        '
        'IdAlumnoDataGridViewTextBoxColumn
        '
        Me.IdAlumnoDataGridViewTextBoxColumn.DataPropertyName = "IdAlumno"
        Me.IdAlumnoDataGridViewTextBoxColumn.HeaderText = "IdAlumno"
        Me.IdAlumnoDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdAlumnoDataGridViewTextBoxColumn.Name = "IdAlumnoDataGridViewTextBoxColumn"
        Me.IdAlumnoDataGridViewTextBoxColumn.Width = 150
        '
        'IdAsigDataGridViewTextBoxColumn
        '
        Me.IdAsigDataGridViewTextBoxColumn.DataPropertyName = "IdAsig"
        Me.IdAsigDataGridViewTextBoxColumn.HeaderText = "IdAsig"
        Me.IdAsigDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IdAsigDataGridViewTextBoxColumn.Name = "IdAsigDataGridViewTextBoxColumn"
        Me.IdAsigDataGridViewTextBoxColumn.Width = 150
        '
        'FechaMatriculaDataGridViewTextBoxColumn
        '
        Me.FechaMatriculaDataGridViewTextBoxColumn.DataPropertyName = "FechaMatricula"
        Me.FechaMatriculaDataGridViewTextBoxColumn.HeaderText = "FechaMatricula"
        Me.FechaMatriculaDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.FechaMatriculaDataGridViewTextBoxColumn.Name = "FechaMatriculaDataGridViewTextBoxColumn"
        Me.FechaMatriculaDataGridViewTextBoxColumn.Width = 150
        '
        'MatriculasBindingNavigator
        '
        Me.MatriculasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.MatriculasBindingNavigator.BindingSource = Me.MatriculasBindingSource
        Me.MatriculasBindingNavigator.CountItem = Me.BindingNavigatorCountItem1
        Me.MatriculasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.MatriculasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.MatriculasBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MatriculasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.MatriculasBindingNavigatorSaveItem})
        Me.MatriculasBindingNavigator.Location = New System.Drawing.Point(12, 838)
        Me.MatriculasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.MatriculasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.MatriculasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.MatriculasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.MatriculasBindingNavigator.Name = "MatriculasBindingNavigator"
        Me.MatriculasBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.MatriculasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem1
        Me.MatriculasBindingNavigator.Size = New System.Drawing.Size(432, 33)
        Me.MatriculasBindingNavigator.TabIndex = 21
        Me.MatriculasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 33)
        '
        'MatriculasBindingNavigatorSaveItem
        '
        Me.MatriculasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MatriculasBindingNavigatorSaveItem.Image = CType(resources.GetObject("MatriculasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MatriculasBindingNavigatorSaveItem.Name = "MatriculasBindingNavigatorSaveItem"
        Me.MatriculasBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.MatriculasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdMatriculaTextBox
        '
        Me.IdMatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculasBindingSource, "IdMatricula", True))
        Me.IdMatriculaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdMatriculaTextBox.Location = New System.Drawing.Point(1001, 636)
        Me.IdMatriculaTextBox.Name = "IdMatriculaTextBox"
        Me.IdMatriculaTextBox.Size = New System.Drawing.Size(130, 30)
        Me.IdMatriculaTextBox.TabIndex = 23
        '
        'IdAlumnoTextBox
        '
        Me.IdAlumnoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculasBindingSource, "IdAlumno", True))
        Me.IdAlumnoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAlumnoTextBox.Location = New System.Drawing.Point(1001, 668)
        Me.IdAlumnoTextBox.Name = "IdAlumnoTextBox"
        Me.IdAlumnoTextBox.Size = New System.Drawing.Size(130, 30)
        Me.IdAlumnoTextBox.TabIndex = 25
        '
        'IdAsigTextBox1
        '
        Me.IdAsigTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculasBindingSource, "IdAsig", True))
        Me.IdAsigTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAsigTextBox1.Location = New System.Drawing.Point(1001, 701)
        Me.IdAsigTextBox1.Name = "IdAsigTextBox1"
        Me.IdAsigTextBox1.Size = New System.Drawing.Size(130, 30)
        Me.IdAsigTextBox1.TabIndex = 27
        '
        'FechaMatriculaTextBox
        '
        Me.FechaMatriculaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MatriculasBindingSource, "FechaMatricula", True))
        Me.FechaMatriculaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaMatriculaTextBox.Location = New System.Drawing.Point(1001, 731)
        Me.FechaMatriculaTextBox.Name = "FechaMatriculaTextBox"
        Me.FechaMatriculaTextBox.Size = New System.Drawing.Size(130, 30)
        Me.FechaMatriculaTextBox.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 28)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ALUMNOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 28)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "ASIGNATURAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 609)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 28)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "MATRICULAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1213, 894)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdMatriculaLabel)
        Me.Controls.Add(Me.IdMatriculaTextBox)
        Me.Controls.Add(IdAlumnoLabel)
        Me.Controls.Add(Me.IdAlumnoTextBox)
        Me.Controls.Add(IdAsigLabel1)
        Me.Controls.Add(Me.IdAsigTextBox1)
        Me.Controls.Add(FechaMatriculaLabel)
        Me.Controls.Add(Me.FechaMatriculaTextBox)
        Me.Controls.Add(Me.MatriculasBindingNavigator)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.AsignaturasBindingNavigator)
        Me.Controls.Add(IdAsigLabel)
        Me.Controls.Add(Me.IdAsigTextBox)
        Me.Controls.Add(AsignaturaLabel)
        Me.Controls.Add(Me.AsignaturaTextBox)
        Me.Controls.Add(Me.AsignaturasDataGridView)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(FechaNacLabel)
        Me.Controls.Add(Me.FechaNacTextBox)
        Me.Controls.Add(ProvinciaLabel)
        Me.Controls.Add(Me.ProvinciaTextBox)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(Me.EdadTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AlumnosBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "MTTOBDII - Alberto Martinez"
        CType(Me.EscuelaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlumnosBindingNavigator.ResumeLayout(False)
        Me.AlumnosBindingNavigator.PerformLayout()
        CType(Me.AlumnosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsignaturasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AsignaturasBindingNavigator.ResumeLayout(False)
        Me.AsignaturasBindingNavigator.PerformLayout()
        CType(Me.MatriculasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatriculasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MatriculasBindingNavigator.ResumeLayout(False)
        Me.MatriculasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EscuelaDataSet As escuelaDataSet
    Friend WithEvents AlumnosBindingSource As BindingSource
    Friend WithEvents AlumnosTableAdapter As escuelaDataSetTableAdapters.alumnosTableAdapter
    Friend WithEvents TableAdapterManager As escuelaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlumnosBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AlumnosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlumnosBindingSource1 As BindingSource
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents FechaNacTextBox As TextBox
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents EdadTextBox As TextBox
    Friend WithEvents AsignaturasBindingSource As BindingSource
    Friend WithEvents AsignaturasTableAdapter As escuelaDataSetTableAdapters.asignaturasTableAdapter
    Friend WithEvents AsignaturasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdAsigTextBox As TextBox
    Friend WithEvents AsignaturaTextBox As TextBox
    Friend WithEvents AsignaturasBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AsignaturasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents MatriculasBindingSource As BindingSource
    Friend WithEvents MatriculasTableAdapter As escuelaDataSetTableAdapters.matriculaTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents IdMatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdAlumnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdAsigDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaMatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MatriculasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents IdMatriculaTextBox As TextBox
    Friend WithEvents IdAlumnoTextBox As TextBox
    Friend WithEvents IdAsigTextBox1 As TextBox
    Friend WithEvents FechaMatriculaTextBox As TextBox
    Friend WithEvents MatriculasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
