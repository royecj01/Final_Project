<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.LocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Artist = New FinalProject.Artist()
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.ArtistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.radArtist = New System.Windows.Forms.RadioButton()
        Me.radLocation = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ArtistsTableAdapter = New FinalProject.ArtistTableAdapters.ArtistsTableAdapter()
        Me.LocationsTableAdapter = New FinalProject.ArtistTableAdapters.LocationsTableAdapter()
        Me.lstOptions = New System.Windows.Forms.ListBox()
        Me.btnTickets = New System.Windows.Forms.Button()
        Me.lblConcert = New System.Windows.Forms.Label()
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Artist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(110, 211)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Find Concert"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cboLocation
        '
        Me.cboLocation.DataSource = Me.LocationsBindingSource
        Me.cboLocation.DisplayMember = "Location"
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(83, 166)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(121, 21)
        Me.cboLocation.TabIndex = 1
        '
        'LocationsBindingSource
        '
        Me.LocationsBindingSource.DataMember = "Locations"
        Me.LocationsBindingSource.DataSource = Me.ArtistBindingSource
        '
        'ArtistBindingSource
        '
        Me.ArtistBindingSource.DataSource = Me.Artist
        Me.ArtistBindingSource.Position = 0
        '
        'Artist
        '
        Me.Artist.DataSetName = "Artist"
        Me.Artist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboArtist
        '
        Me.cboArtist.DataSource = Me.ArtistsBindingSource
        Me.cboArtist.DisplayMember = "Artist Name"
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Location = New System.Drawing.Point(83, 84)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(121, 21)
        Me.cboArtist.TabIndex = 2
        '
        'ArtistsBindingSource
        '
        Me.ArtistsBindingSource.DataMember = "Artists"
        Me.ArtistsBindingSource.DataSource = Me.ArtistBindingSource
        '
        'radArtist
        '
        Me.radArtist.AutoSize = True
        Me.radArtist.Location = New System.Drawing.Point(92, 61)
        Me.radArtist.Name = "radArtist"
        Me.radArtist.Size = New System.Drawing.Size(103, 17)
        Me.radArtist.TabIndex = 3
        Me.radArtist.TabStop = True
        Me.radArtist.Text = "Search By Artist:"
        Me.radArtist.UseVisualStyleBackColor = True
        '
        'radLocation
        '
        Me.radLocation.AutoSize = True
        Me.radLocation.Location = New System.Drawing.Point(92, 143)
        Me.radLocation.Name = "radLocation"
        Me.radLocation.Size = New System.Drawing.Size(121, 17)
        Me.radLocation.TabIndex = 4
        Me.radLocation.TabStop = True
        Me.radLocation.Text = "Search By Location:"
        Me.radLocation.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Please select how you would like to find your concert:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "OR:"
        '
        'ArtistsTableAdapter
        '
        Me.ArtistsTableAdapter.ClearBeforeFill = True
        '
        'LocationsTableAdapter
        '
        Me.LocationsTableAdapter.ClearBeforeFill = True
        '
        'lstOptions
        '
        Me.lstOptions.DataSource = Me.ArtistsBindingSource
        Me.lstOptions.DisplayMember = "Artist Name"
        Me.lstOptions.FormattingEnabled = True
        Me.lstOptions.Location = New System.Drawing.Point(65, 285)
        Me.lstOptions.Name = "lstOptions"
        Me.lstOptions.Size = New System.Drawing.Size(164, 160)
        Me.lstOptions.TabIndex = 7
        '
        'btnTickets
        '
        Me.btnTickets.Location = New System.Drawing.Point(110, 451)
        Me.btnTickets.Name = "btnTickets"
        Me.btnTickets.Size = New System.Drawing.Size(75, 23)
        Me.btnTickets.TabIndex = 8
        Me.btnTickets.Text = "Find Tickets"
        Me.btnTickets.UseVisualStyleBackColor = True
        '
        'lblConcert
        '
        Me.lblConcert.AutoSize = True
        Me.lblConcert.Location = New System.Drawing.Point(53, 258)
        Me.lblConcert.Name = "lblConcert"
        Me.lblConcert.Size = New System.Drawing.Size(185, 13)
        Me.lblConcert.TabIndex = 9
        Me.lblConcert.Text = "Please select from available concerts:"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 486)
        Me.Controls.Add(Me.lblConcert)
        Me.Controls.Add(Me.btnTickets)
        Me.Controls.Add(Me.lstOptions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.radLocation)
        Me.Controls.Add(Me.radArtist)
        Me.Controls.Add(Me.cboArtist)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Artist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents cboArtist As ComboBox
    Friend WithEvents radArtist As RadioButton
    Friend WithEvents radLocation As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ArtistBindingSource As BindingSource
    Friend WithEvents Artist As Artist
    Friend WithEvents ArtistsBindingSource As BindingSource
    Friend WithEvents ArtistsTableAdapter As ArtistTableAdapters.ArtistsTableAdapter
    Friend WithEvents LocationsBindingSource As BindingSource
    Friend WithEvents LocationsTableAdapter As ArtistTableAdapters.LocationsTableAdapter
    Friend WithEvents lstOptions As ListBox
    Friend WithEvents btnTickets As Button
    Friend WithEvents lblConcert As Label
End Class
