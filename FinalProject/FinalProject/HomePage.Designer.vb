<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.radArtist = New System.Windows.Forms.RadioButton()
        Me.radLocation = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboArtist = New System.Windows.Forms.ComboBox()
        Me.Artist = New FinalProject.Artist()
        Me.ArtistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtistsTableAdapter = New FinalProject.ArtistTableAdapters.ArtistsTableAdapter()
        Me.Artist1 = New FinalProject.Artist()
        Me.LocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationsTableAdapter = New FinalProject.ArtistTableAdapters.LocationsTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Artist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Artist1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please choose how you would like to find your concert:"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(104, 217)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(90, 23)
        Me.btnFind.TabIndex = 5
        Me.btnFind.Text = "Find A Concert"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'cboLocation
        '
        Me.cboLocation.DataSource = Me.LocationsBindingSource
        Me.cboLocation.DisplayMember = "Location"
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.Location = New System.Drawing.Point(15, 159)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(121, 21)
        Me.cboLocation.TabIndex = 6
        '
        'radArtist
        '
        Me.radArtist.AutoSize = True
        Me.radArtist.Location = New System.Drawing.Point(12, 54)
        Me.radArtist.Name = "radArtist"
        Me.radArtist.Size = New System.Drawing.Size(100, 17)
        Me.radArtist.TabIndex = 7
        Me.radArtist.TabStop = True
        Me.radArtist.Text = "Search By Artist"
        Me.radArtist.UseVisualStyleBackColor = True
        '
        'radLocation
        '
        Me.radLocation.AutoSize = True
        Me.radLocation.Location = New System.Drawing.Point(12, 136)
        Me.radLocation.Name = "radLocation"
        Me.radLocation.Size = New System.Drawing.Size(118, 17)
        Me.radLocation.TabIndex = 8
        Me.radLocation.TabStop = True
        Me.radLocation.Text = "Search By Location"
        Me.radLocation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "OR"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(160, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'cboArtist
        '
        Me.cboArtist.DataSource = Me.ArtistsBindingSource
        Me.cboArtist.DisplayMember = "Artist Name"
        Me.cboArtist.FormattingEnabled = True
        Me.cboArtist.Location = New System.Drawing.Point(15, 77)
        Me.cboArtist.Name = "cboArtist"
        Me.cboArtist.Size = New System.Drawing.Size(121, 21)
        Me.cboArtist.TabIndex = 11
        '
        'Artist
        '
        Me.Artist.DataSetName = "Artist"
        Me.Artist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtistsBindingSource
        '
        Me.ArtistsBindingSource.DataMember = "Artists"
        Me.ArtistsBindingSource.DataSource = Me.Artist
        '
        'ArtistsTableAdapter
        '
        Me.ArtistsTableAdapter.ClearBeforeFill = True
        '
        'Artist1
        '
        Me.Artist1.DataSetName = "Artist"
        Me.Artist1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocationsBindingSource
        '
        Me.LocationsBindingSource.DataMember = "Locations"
        Me.LocationsBindingSource.DataSource = Me.Artist1
        '
        'LocationsTableAdapter
        '
        Me.LocationsTableAdapter.ClearBeforeFill = True
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 261)
        Me.Controls.Add(Me.cboLocation)
        Me.Controls.Add(Me.radLocation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboArtist)
        Me.Controls.Add(Me.radArtist)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HomePage"
        Me.Text = "Concert Tickets"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Artist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Artist1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents radArtist As RadioButton
    Friend WithEvents radLocation As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cboArtist As ComboBox
    Friend WithEvents Artist As Artist
    Friend WithEvents ArtistsBindingSource As BindingSource
    Friend WithEvents ArtistsTableAdapter As ArtistTableAdapters.ArtistsTableAdapter
    Friend WithEvents Artist1 As Artist
    Friend WithEvents LocationsBindingSource As BindingSource
    Friend WithEvents LocationsTableAdapter As ArtistTableAdapters.LocationsTableAdapter
End Class
