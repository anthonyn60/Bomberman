<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tmrBomb = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBomb2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrExplosion1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrExplosion2 = New System.Windows.Forms.Timer(Me.components)
        Me.picBomb2 = New System.Windows.Forms.PictureBox
        Me.picExplode2 = New System.Windows.Forms.PictureBox
        Me.picExplodeDown6 = New System.Windows.Forms.PictureBox
        Me.picExplodeDown5 = New System.Windows.Forms.PictureBox
        Me.picExplodeUp5 = New System.Windows.Forms.PictureBox
        Me.picExplodeUp6 = New System.Windows.Forms.PictureBox
        Me.picExplodeLeft5 = New System.Windows.Forms.PictureBox
        Me.picExplodeLeft6 = New System.Windows.Forms.PictureBox
        Me.picExplodeRight6 = New System.Windows.Forms.PictureBox
        Me.picExplodeRight5 = New System.Windows.Forms.PictureBox
        Me.picBomb1 = New System.Windows.Forms.PictureBox
        Me.picExplode1 = New System.Windows.Forms.PictureBox
        Me.picExplodeDown4 = New System.Windows.Forms.PictureBox
        Me.picExplodeDown2 = New System.Windows.Forms.PictureBox
        Me.picExplodeDown3 = New System.Windows.Forms.PictureBox
        Me.picExplodeDown = New System.Windows.Forms.PictureBox
        Me.picExplodeUp4 = New System.Windows.Forms.PictureBox
        Me.picExplodeUp2 = New System.Windows.Forms.PictureBox
        Me.picExplodeUp3 = New System.Windows.Forms.PictureBox
        Me.picExplodeUp = New System.Windows.Forms.PictureBox
        Me.picExplodeRight4 = New System.Windows.Forms.PictureBox
        Me.picExplodeRight3 = New System.Windows.Forms.PictureBox
        Me.picExplodeRight = New System.Windows.Forms.PictureBox
        Me.picExplodeRight2 = New System.Windows.Forms.PictureBox
        Me.picExplodeLeft4 = New System.Windows.Forms.PictureBox
        Me.picExplodeLeft3 = New System.Windows.Forms.PictureBox
        Me.picExplodeLeft2 = New System.Windows.Forms.PictureBox
        Me.picExplodeLeft = New System.Windows.Forms.PictureBox
        Me.picFire1 = New System.Windows.Forms.PictureBox
        Me.picFire2 = New System.Windows.Forms.PictureBox
        Me.picBrick21 = New System.Windows.Forms.PictureBox
        Me.picBrick73 = New System.Windows.Forms.PictureBox
        Me.picBrick24 = New System.Windows.Forms.PictureBox
        Me.picBrick22 = New System.Windows.Forms.PictureBox
        Me.picBrick17 = New System.Windows.Forms.PictureBox
        Me.picBrick58 = New System.Windows.Forms.PictureBox
        Me.picBrick2 = New System.Windows.Forms.PictureBox
        Me.picBrick1 = New System.Windows.Forms.PictureBox
        Me.picBrick60 = New System.Windows.Forms.PictureBox
        Me.picBrick57 = New System.Windows.Forms.PictureBox
        Me.picBrick72 = New System.Windows.Forms.PictureBox
        Me.picBrick71 = New System.Windows.Forms.PictureBox
        Me.picBrick70 = New System.Windows.Forms.PictureBox
        Me.picBrick20 = New System.Windows.Forms.PictureBox
        Me.picBrick19 = New System.Windows.Forms.PictureBox
        Me.picBrick18 = New System.Windows.Forms.PictureBox
        Me.picBrick47 = New System.Windows.Forms.PictureBox
        Me.picBrick51 = New System.Windows.Forms.PictureBox
        Me.picBrick56 = New System.Windows.Forms.PictureBox
        Me.picBrick63 = New System.Windows.Forms.PictureBox
        Me.picBrick62 = New System.Windows.Forms.PictureBox
        Me.picBrick61 = New System.Windows.Forms.PictureBox
        Me.picBrick69 = New System.Windows.Forms.PictureBox
        Me.picBrick68 = New System.Windows.Forms.PictureBox
        Me.picBrick38 = New System.Windows.Forms.PictureBox
        Me.picBrick7 = New System.Windows.Forms.PictureBox
        Me.picBrick6 = New System.Windows.Forms.PictureBox
        Me.picBrick45 = New System.Windows.Forms.PictureBox
        Me.picBrick44 = New System.Windows.Forms.PictureBox
        Me.picBrick43 = New System.Windows.Forms.PictureBox
        Me.picBrick42 = New System.Windows.Forms.PictureBox
        Me.picBrick54 = New System.Windows.Forms.PictureBox
        Me.picBrick53 = New System.Windows.Forms.PictureBox
        Me.picBrick52 = New System.Windows.Forms.PictureBox
        Me.picBrick50 = New System.Windows.Forms.PictureBox
        Me.picBrick46 = New System.Windows.Forms.PictureBox
        Me.picBrick40 = New System.Windows.Forms.PictureBox
        Me.picBrick55 = New System.Windows.Forms.PictureBox
        Me.picBrick49 = New System.Windows.Forms.PictureBox
        Me.picBrick59 = New System.Windows.Forms.PictureBox
        Me.picBrick67 = New System.Windows.Forms.PictureBox
        Me.picBrick66 = New System.Windows.Forms.PictureBox
        Me.picBrick65 = New System.Windows.Forms.PictureBox
        Me.picBrick64 = New System.Windows.Forms.PictureBox
        Me.picBrick41 = New System.Windows.Forms.PictureBox
        Me.picBrick37 = New System.Windows.Forms.PictureBox
        Me.picBrick48 = New System.Windows.Forms.PictureBox
        Me.picBrick36 = New System.Windows.Forms.PictureBox
        Me.picBrick35 = New System.Windows.Forms.PictureBox
        Me.picBrick34 = New System.Windows.Forms.PictureBox
        Me.picBrick15 = New System.Windows.Forms.PictureBox
        Me.picBrick9 = New System.Windows.Forms.PictureBox
        Me.picBrick29 = New System.Windows.Forms.PictureBox
        Me.picBrick23 = New System.Windows.Forms.PictureBox
        Me.picBrick5 = New System.Windows.Forms.PictureBox
        Me.picBrick4 = New System.Windows.Forms.PictureBox
        Me.picBrick33 = New System.Windows.Forms.PictureBox
        Me.picBrick32 = New System.Windows.Forms.PictureBox
        Me.picBrick8 = New System.Windows.Forms.PictureBox
        Me.picBrick3 = New System.Windows.Forms.PictureBox
        Me.picBrick14 = New System.Windows.Forms.PictureBox
        Me.picBrick13 = New System.Windows.Forms.PictureBox
        Me.picBrick26 = New System.Windows.Forms.PictureBox
        Me.picBrick39 = New System.Windows.Forms.PictureBox
        Me.picBrick25 = New System.Windows.Forms.PictureBox
        Me.picBrick31 = New System.Windows.Forms.PictureBox
        Me.picBrick30 = New System.Windows.Forms.PictureBox
        Me.picBrick28 = New System.Windows.Forms.PictureBox
        Me.picBrick27 = New System.Windows.Forms.PictureBox
        Me.picBrick16 = New System.Windows.Forms.PictureBox
        Me.picBrick12 = New System.Windows.Forms.PictureBox
        Me.picBrick11 = New System.Windows.Forms.PictureBox
        Me.picBrick10 = New System.Windows.Forms.PictureBox
        Me.picBomberman2 = New System.Windows.Forms.PictureBox
        Me.picMetal48 = New System.Windows.Forms.PictureBox
        Me.picMetal47 = New System.Windows.Forms.PictureBox
        Me.picMetal46 = New System.Windows.Forms.PictureBox
        Me.picMetal45 = New System.Windows.Forms.PictureBox
        Me.picMetal44 = New System.Windows.Forms.PictureBox
        Me.picMetal43 = New System.Windows.Forms.PictureBox
        Me.picMetal42 = New System.Windows.Forms.PictureBox
        Me.picMetal41 = New System.Windows.Forms.PictureBox
        Me.picMetal40 = New System.Windows.Forms.PictureBox
        Me.picMetal39 = New System.Windows.Forms.PictureBox
        Me.picMetal38 = New System.Windows.Forms.PictureBox
        Me.picMetal37 = New System.Windows.Forms.PictureBox
        Me.picMetal36 = New System.Windows.Forms.PictureBox
        Me.picMetal35 = New System.Windows.Forms.PictureBox
        Me.picMetal34 = New System.Windows.Forms.PictureBox
        Me.picMetal33 = New System.Windows.Forms.PictureBox
        Me.picMetal32 = New System.Windows.Forms.PictureBox
        Me.picMetal31 = New System.Windows.Forms.PictureBox
        Me.picMetal30 = New System.Windows.Forms.PictureBox
        Me.picMetal29 = New System.Windows.Forms.PictureBox
        Me.picMetal28 = New System.Windows.Forms.PictureBox
        Me.picMetal27 = New System.Windows.Forms.PictureBox
        Me.picMetal26 = New System.Windows.Forms.PictureBox
        Me.picMetal25 = New System.Windows.Forms.PictureBox
        Me.picMetal24 = New System.Windows.Forms.PictureBox
        Me.picMetal23 = New System.Windows.Forms.PictureBox
        Me.picMetal22 = New System.Windows.Forms.PictureBox
        Me.picMetal21 = New System.Windows.Forms.PictureBox
        Me.picMetal20 = New System.Windows.Forms.PictureBox
        Me.picMetal19 = New System.Windows.Forms.PictureBox
        Me.picMetal18 = New System.Windows.Forms.PictureBox
        Me.picMetal17 = New System.Windows.Forms.PictureBox
        Me.picMetal16 = New System.Windows.Forms.PictureBox
        Me.picMetal15 = New System.Windows.Forms.PictureBox
        Me.picMetal14 = New System.Windows.Forms.PictureBox
        Me.picMetal13 = New System.Windows.Forms.PictureBox
        Me.picMetal12 = New System.Windows.Forms.PictureBox
        Me.picMetal11 = New System.Windows.Forms.PictureBox
        Me.picMetal10 = New System.Windows.Forms.PictureBox
        Me.picMetal9 = New System.Windows.Forms.PictureBox
        Me.picMetal8 = New System.Windows.Forms.PictureBox
        Me.picMetal7 = New System.Windows.Forms.PictureBox
        Me.picMetal6 = New System.Windows.Forms.PictureBox
        Me.picMetal5 = New System.Windows.Forms.PictureBox
        Me.picMetal4 = New System.Windows.Forms.PictureBox
        Me.picMetal3 = New System.Windows.Forms.PictureBox
        Me.picMetal2 = New System.Windows.Forms.PictureBox
        Me.picBomberman1 = New System.Windows.Forms.PictureBox
        Me.picMetal = New System.Windows.Forms.PictureBox
        Me.picFrameRight = New System.Windows.Forms.PictureBox
        Me.picFrameBottom = New System.Windows.Forms.PictureBox
        Me.picFrameLeft = New System.Windows.Forms.PictureBox
        Me.picFrameTop = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picBomb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeDown6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeDown5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeUp5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeUp6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeLeft5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeLeft6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeRight6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeRight5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBomb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplode1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeUp4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeUp2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeUp3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeRight4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeRight3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeRight2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeLeft4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeLeft3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeLeft2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picExplodeLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFire1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFire2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick73, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick72, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick70, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick49, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrick10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBomberman2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBomberman1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMetal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrameRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrameBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrameLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrameTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(330, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'tmrBomb
        '
        Me.tmrBomb.Interval = 1500
        '
        'tmrBomb2
        '
        Me.tmrBomb2.Interval = 1500
        '
        'tmrExplosion1
        '
        Me.tmrExplosion1.Interval = 1000
        '
        'tmrExplosion2
        '
        Me.tmrExplosion2.Interval = 1000
        '
        'picBomb2
        '
        Me.picBomb2.Image = Global.Bomberman.My.Resources.Resources.bomb
        Me.picBomb2.Location = New System.Drawing.Point(550, 431)
        Me.picBomb2.Name = "picBomb2"
        Me.picBomb2.Size = New System.Drawing.Size(21, 28)
        Me.picBomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBomb2.TabIndex = 166
        Me.picBomb2.TabStop = False
        '
        'picExplode2
        '
        Me.picExplode2.Image = Global.Bomberman.My.Resources.Resources.bomb_explode
        Me.picExplode2.Location = New System.Drawing.Point(599, 406)
        Me.picExplode2.Name = "picExplode2"
        Me.picExplode2.Size = New System.Drawing.Size(21, 28)
        Me.picExplode2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplode2.TabIndex = 165
        Me.picExplode2.TabStop = False
        '
        'picExplodeDown6
        '
        Me.picExplodeDown6.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeDown6.Location = New System.Drawing.Point(604, 336)
        Me.picExplodeDown6.Name = "picExplodeDown6"
        Me.picExplodeDown6.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeDown6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeDown6.TabIndex = 164
        Me.picExplodeDown6.TabStop = False
        '
        'picExplodeDown5
        '
        Me.picExplodeDown5.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeDown5.Location = New System.Drawing.Point(577, 364)
        Me.picExplodeDown5.Name = "picExplodeDown5"
        Me.picExplodeDown5.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeDown5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeDown5.TabIndex = 163
        Me.picExplodeDown5.TabStop = False
        '
        'picExplodeUp5
        '
        Me.picExplodeUp5.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeUp5.Location = New System.Drawing.Point(577, 280)
        Me.picExplodeUp5.Name = "picExplodeUp5"
        Me.picExplodeUp5.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeUp5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeUp5.TabIndex = 162
        Me.picExplodeUp5.TabStop = False
        '
        'picExplodeUp6
        '
        Me.picExplodeUp6.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeUp6.Location = New System.Drawing.Point(550, 308)
        Me.picExplodeUp6.Name = "picExplodeUp6"
        Me.picExplodeUp6.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeUp6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeUp6.TabIndex = 161
        Me.picExplodeUp6.TabStop = False
        '
        'picExplodeLeft5
        '
        Me.picExplodeLeft5.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeLeft5.Location = New System.Drawing.Point(565, 105)
        Me.picExplodeLeft5.Name = "picExplodeLeft5"
        Me.picExplodeLeft5.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeLeft5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeLeft5.TabIndex = 160
        Me.picExplodeLeft5.TabStop = False
        '
        'picExplodeLeft6
        '
        Me.picExplodeLeft6.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeLeft6.Location = New System.Drawing.Point(599, 84)
        Me.picExplodeLeft6.Name = "picExplodeLeft6"
        Me.picExplodeLeft6.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeLeft6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeLeft6.TabIndex = 159
        Me.picExplodeLeft6.TabStop = False
        '
        'picExplodeRight6
        '
        Me.picExplodeRight6.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeRight6.Location = New System.Drawing.Point(628, 224)
        Me.picExplodeRight6.Name = "picExplodeRight6"
        Me.picExplodeRight6.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeRight6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeRight6.TabIndex = 158
        Me.picExplodeRight6.TabStop = False
        '
        'picExplodeRight5
        '
        Me.picExplodeRight5.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeRight5.Location = New System.Drawing.Point(599, 181)
        Me.picExplodeRight5.Name = "picExplodeRight5"
        Me.picExplodeRight5.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeRight5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeRight5.TabIndex = 157
        Me.picExplodeRight5.TabStop = False
        '
        'picBomb1
        '
        Me.picBomb1.Image = Global.Bomberman.My.Resources.Resources.bomb
        Me.picBomb1.Location = New System.Drawing.Point(506, 476)
        Me.picBomb1.Name = "picBomb1"
        Me.picBomb1.Size = New System.Drawing.Size(21, 28)
        Me.picBomb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBomb1.TabIndex = 156
        Me.picBomb1.TabStop = False
        '
        'picExplode1
        '
        Me.picExplode1.Image = Global.Bomberman.My.Resources.Resources.bomb_explode
        Me.picExplode1.Location = New System.Drawing.Point(550, 476)
        Me.picExplode1.Name = "picExplode1"
        Me.picExplode1.Size = New System.Drawing.Size(21, 28)
        Me.picExplode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplode1.TabIndex = 155
        Me.picExplode1.TabStop = False
        '
        'picExplodeDown4
        '
        Me.picExplodeDown4.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeDown4.Location = New System.Drawing.Point(479, 406)
        Me.picExplodeDown4.Name = "picExplodeDown4"
        Me.picExplodeDown4.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeDown4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeDown4.TabIndex = 154
        Me.picExplodeDown4.TabStop = False
        '
        'picExplodeDown2
        '
        Me.picExplodeDown2.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeDown2.Location = New System.Drawing.Point(535, 350)
        Me.picExplodeDown2.Name = "picExplodeDown2"
        Me.picExplodeDown2.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeDown2.TabIndex = 153
        Me.picExplodeDown2.TabStop = False
        '
        'picExplodeDown3
        '
        Me.picExplodeDown3.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeDown3.Location = New System.Drawing.Point(508, 378)
        Me.picExplodeDown3.Name = "picExplodeDown3"
        Me.picExplodeDown3.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeDown3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeDown3.TabIndex = 152
        Me.picExplodeDown3.TabStop = False
        '
        'picExplodeDown
        '
        Me.picExplodeDown.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeDown.Location = New System.Drawing.Point(479, 350)
        Me.picExplodeDown.Name = "picExplodeDown"
        Me.picExplodeDown.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeDown.TabIndex = 151
        Me.picExplodeDown.TabStop = False
        '
        'picExplodeUp4
        '
        Me.picExplodeUp4.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeUp4.Location = New System.Drawing.Point(479, 308)
        Me.picExplodeUp4.Name = "picExplodeUp4"
        Me.picExplodeUp4.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeUp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeUp4.TabIndex = 150
        Me.picExplodeUp4.TabStop = False
        '
        'picExplodeUp2
        '
        Me.picExplodeUp2.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeUp2.Location = New System.Drawing.Point(535, 252)
        Me.picExplodeUp2.Name = "picExplodeUp2"
        Me.picExplodeUp2.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeUp2.TabIndex = 149
        Me.picExplodeUp2.TabStop = False
        '
        'picExplodeUp3
        '
        Me.picExplodeUp3.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeUp3.Location = New System.Drawing.Point(508, 280)
        Me.picExplodeUp3.Name = "picExplodeUp3"
        Me.picExplodeUp3.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeUp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeUp3.TabIndex = 148
        Me.picExplodeUp3.TabStop = False
        '
        'picExplodeUp
        '
        Me.picExplodeUp.Image = Global.Bomberman.My.Resources.Resources.explode_up_down
        Me.picExplodeUp.Location = New System.Drawing.Point(479, 252)
        Me.picExplodeUp.Name = "picExplodeUp"
        Me.picExplodeUp.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeUp.TabIndex = 147
        Me.picExplodeUp.TabStop = False
        '
        'picExplodeRight4
        '
        Me.picExplodeRight4.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeRight4.Location = New System.Drawing.Point(506, 431)
        Me.picExplodeRight4.Name = "picExplodeRight4"
        Me.picExplodeRight4.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeRight4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeRight4.TabIndex = 146
        Me.picExplodeRight4.TabStop = False
        '
        'picExplodeRight3
        '
        Me.picExplodeRight3.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeRight3.Location = New System.Drawing.Point(508, 196)
        Me.picExplodeRight3.Name = "picExplodeRight3"
        Me.picExplodeRight3.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeRight3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeRight3.TabIndex = 145
        Me.picExplodeRight3.TabStop = False
        '
        'picExplodeRight
        '
        Me.picExplodeRight.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeRight.Location = New System.Drawing.Point(479, 153)
        Me.picExplodeRight.Name = "picExplodeRight"
        Me.picExplodeRight.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeRight.TabIndex = 144
        Me.picExplodeRight.TabStop = False
        '
        'picExplodeRight2
        '
        Me.picExplodeRight2.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeRight2.Location = New System.Drawing.Point(542, 153)
        Me.picExplodeRight2.Name = "picExplodeRight2"
        Me.picExplodeRight2.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeRight2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeRight2.TabIndex = 143
        Me.picExplodeRight2.TabStop = False
        '
        'picExplodeLeft4
        '
        Me.picExplodeLeft4.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeLeft4.Location = New System.Drawing.Point(519, 118)
        Me.picExplodeLeft4.Name = "picExplodeLeft4"
        Me.picExplodeLeft4.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeLeft4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeLeft4.TabIndex = 142
        Me.picExplodeLeft4.TabStop = False
        '
        'picExplodeLeft3
        '
        Me.picExplodeLeft3.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeLeft3.Location = New System.Drawing.Point(508, 84)
        Me.picExplodeLeft3.Name = "picExplodeLeft3"
        Me.picExplodeLeft3.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeLeft3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeLeft3.TabIndex = 141
        Me.picExplodeLeft3.TabStop = False
        '
        'picExplodeLeft2
        '
        Me.picExplodeLeft2.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeLeft2.Location = New System.Drawing.Point(479, 63)
        Me.picExplodeLeft2.Name = "picExplodeLeft2"
        Me.picExplodeLeft2.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeLeft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeLeft2.TabIndex = 140
        Me.picExplodeLeft2.TabStop = False
        '
        'picExplodeLeft
        '
        Me.picExplodeLeft.Image = Global.Bomberman.My.Resources.Resources.explode_left_right
        Me.picExplodeLeft.Location = New System.Drawing.Point(542, 63)
        Me.picExplodeLeft.Name = "picExplodeLeft"
        Me.picExplodeLeft.Size = New System.Drawing.Size(21, 28)
        Me.picExplodeLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picExplodeLeft.TabIndex = 139
        Me.picExplodeLeft.TabStop = False
        '
        'picFire1
        '
        Me.picFire1.Image = Global.Bomberman.My.Resources.Resources.bomberman_fire
        Me.picFire1.Location = New System.Drawing.Point(216, 56)
        Me.picFire1.Name = "picFire1"
        Me.picFire1.Size = New System.Drawing.Size(21, 28)
        Me.picFire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFire1.TabIndex = 137
        Me.picFire1.TabStop = False
        '
        'picFire2
        '
        Me.picFire2.Image = Global.Bomberman.My.Resources.Resources.bomberman_fire
        Me.picFire2.Location = New System.Drawing.Point(132, 448)
        Me.picFire2.Name = "picFire2"
        Me.picFire2.Size = New System.Drawing.Size(21, 28)
        Me.picFire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFire2.TabIndex = 136
        Me.picFire2.TabStop = False
        '
        'picBrick21
        '
        Me.picBrick21.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick21.Location = New System.Drawing.Point(216, 168)
        Me.picBrick21.Name = "picBrick21"
        Me.picBrick21.Size = New System.Drawing.Size(21, 28)
        Me.picBrick21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick21.TabIndex = 128
        Me.picBrick21.TabStop = False
        '
        'picBrick73
        '
        Me.picBrick73.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick73.Location = New System.Drawing.Point(216, 504)
        Me.picBrick73.Name = "picBrick73"
        Me.picBrick73.Size = New System.Drawing.Size(21, 28)
        Me.picBrick73.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick73.TabIndex = 127
        Me.picBrick73.TabStop = False
        '
        'picBrick24
        '
        Me.picBrick24.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick24.Location = New System.Drawing.Point(279, 196)
        Me.picBrick24.Name = "picBrick24"
        Me.picBrick24.Size = New System.Drawing.Size(21, 28)
        Me.picBrick24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick24.TabIndex = 126
        Me.picBrick24.TabStop = False
        '
        'picBrick22
        '
        Me.picBrick22.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick22.Location = New System.Drawing.Point(279, 168)
        Me.picBrick22.Name = "picBrick22"
        Me.picBrick22.Size = New System.Drawing.Size(21, 28)
        Me.picBrick22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick22.TabIndex = 125
        Me.picBrick22.TabStop = False
        '
        'picBrick17
        '
        Me.picBrick17.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick17.Location = New System.Drawing.Point(279, 140)
        Me.picBrick17.Name = "picBrick17"
        Me.picBrick17.Size = New System.Drawing.Size(21, 28)
        Me.picBrick17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick17.TabIndex = 124
        Me.picBrick17.TabStop = False
        '
        'picBrick58
        '
        Me.picBrick58.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick58.Location = New System.Drawing.Point(111, 420)
        Me.picBrick58.Name = "picBrick58"
        Me.picBrick58.Size = New System.Drawing.Size(21, 28)
        Me.picBrick58.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick58.TabIndex = 123
        Me.picBrick58.TabStop = False
        '
        'picBrick2
        '
        Me.picBrick2.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick2.Location = New System.Drawing.Point(111, 56)
        Me.picBrick2.Name = "picBrick2"
        Me.picBrick2.Size = New System.Drawing.Size(21, 28)
        Me.picBrick2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick2.TabIndex = 122
        Me.picBrick2.TabStop = False
        '
        'picBrick1
        '
        Me.picBrick1.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick1.Location = New System.Drawing.Point(90, 56)
        Me.picBrick1.Name = "picBrick1"
        Me.picBrick1.Size = New System.Drawing.Size(21, 28)
        Me.picBrick1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick1.TabIndex = 121
        Me.picBrick1.TabStop = False
        '
        'picBrick60
        '
        Me.picBrick60.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick60.Location = New System.Drawing.Point(279, 420)
        Me.picBrick60.Name = "picBrick60"
        Me.picBrick60.Size = New System.Drawing.Size(21, 28)
        Me.picBrick60.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick60.TabIndex = 120
        Me.picBrick60.TabStop = False
        '
        'picBrick57
        '
        Me.picBrick57.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick57.Location = New System.Drawing.Point(279, 392)
        Me.picBrick57.Name = "picBrick57"
        Me.picBrick57.Size = New System.Drawing.Size(21, 28)
        Me.picBrick57.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick57.TabIndex = 119
        Me.picBrick57.TabStop = False
        '
        'picBrick72
        '
        Me.picBrick72.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick72.Location = New System.Drawing.Point(174, 504)
        Me.picBrick72.Name = "picBrick72"
        Me.picBrick72.Size = New System.Drawing.Size(21, 28)
        Me.picBrick72.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick72.TabIndex = 118
        Me.picBrick72.TabStop = False
        '
        'picBrick71
        '
        Me.picBrick71.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick71.Location = New System.Drawing.Point(153, 504)
        Me.picBrick71.Name = "picBrick71"
        Me.picBrick71.Size = New System.Drawing.Size(21, 28)
        Me.picBrick71.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick71.TabIndex = 117
        Me.picBrick71.TabStop = False
        '
        'picBrick70
        '
        Me.picBrick70.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick70.Location = New System.Drawing.Point(132, 504)
        Me.picBrick70.Name = "picBrick70"
        Me.picBrick70.Size = New System.Drawing.Size(21, 28)
        Me.picBrick70.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick70.TabIndex = 116
        Me.picBrick70.TabStop = False
        '
        'picBrick20
        '
        Me.picBrick20.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick20.Location = New System.Drawing.Point(153, 168)
        Me.picBrick20.Name = "picBrick20"
        Me.picBrick20.Size = New System.Drawing.Size(21, 28)
        Me.picBrick20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick20.TabIndex = 115
        Me.picBrick20.TabStop = False
        '
        'picBrick19
        '
        Me.picBrick19.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick19.Location = New System.Drawing.Point(132, 168)
        Me.picBrick19.Name = "picBrick19"
        Me.picBrick19.Size = New System.Drawing.Size(21, 28)
        Me.picBrick19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick19.TabIndex = 114
        Me.picBrick19.TabStop = False
        '
        'picBrick18
        '
        Me.picBrick18.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick18.Location = New System.Drawing.Point(27, 168)
        Me.picBrick18.Name = "picBrick18"
        Me.picBrick18.Size = New System.Drawing.Size(21, 28)
        Me.picBrick18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick18.TabIndex = 113
        Me.picBrick18.TabStop = False
        '
        'picBrick47
        '
        Me.picBrick47.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick47.Location = New System.Drawing.Point(237, 336)
        Me.picBrick47.Name = "picBrick47"
        Me.picBrick47.Size = New System.Drawing.Size(21, 28)
        Me.picBrick47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick47.TabIndex = 112
        Me.picBrick47.TabStop = False
        '
        'picBrick51
        '
        Me.picBrick51.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick51.Location = New System.Drawing.Point(237, 364)
        Me.picBrick51.Name = "picBrick51"
        Me.picBrick51.Size = New System.Drawing.Size(21, 28)
        Me.picBrick51.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick51.TabIndex = 111
        Me.picBrick51.TabStop = False
        '
        'picBrick56
        '
        Me.picBrick56.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick56.Location = New System.Drawing.Point(237, 392)
        Me.picBrick56.Name = "picBrick56"
        Me.picBrick56.Size = New System.Drawing.Size(21, 28)
        Me.picBrick56.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick56.TabIndex = 110
        Me.picBrick56.TabStop = False
        '
        'picBrick63
        '
        Me.picBrick63.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick63.Location = New System.Drawing.Point(69, 448)
        Me.picBrick63.Name = "picBrick63"
        Me.picBrick63.Size = New System.Drawing.Size(21, 28)
        Me.picBrick63.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick63.TabIndex = 109
        Me.picBrick63.TabStop = False
        '
        'picBrick62
        '
        Me.picBrick62.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick62.Location = New System.Drawing.Point(48, 448)
        Me.picBrick62.Name = "picBrick62"
        Me.picBrick62.Size = New System.Drawing.Size(21, 28)
        Me.picBrick62.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick62.TabIndex = 108
        Me.picBrick62.TabStop = False
        '
        'picBrick61
        '
        Me.picBrick61.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick61.Location = New System.Drawing.Point(27, 448)
        Me.picBrick61.Name = "picBrick61"
        Me.picBrick61.Size = New System.Drawing.Size(21, 28)
        Me.picBrick61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick61.TabIndex = 107
        Me.picBrick61.TabStop = False
        '
        'picBrick69
        '
        Me.picBrick69.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick69.Location = New System.Drawing.Point(48, 504)
        Me.picBrick69.Name = "picBrick69"
        Me.picBrick69.Size = New System.Drawing.Size(21, 28)
        Me.picBrick69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick69.TabIndex = 106
        Me.picBrick69.TabStop = False
        '
        'picBrick68
        '
        Me.picBrick68.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick68.Location = New System.Drawing.Point(27, 504)
        Me.picBrick68.Name = "picBrick68"
        Me.picBrick68.Size = New System.Drawing.Size(21, 28)
        Me.picBrick68.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick68.TabIndex = 105
        Me.picBrick68.TabStop = False
        '
        'picBrick38
        '
        Me.picBrick38.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick38.Location = New System.Drawing.Point(27, 308)
        Me.picBrick38.Name = "picBrick38"
        Me.picBrick38.Size = New System.Drawing.Size(21, 28)
        Me.picBrick38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick38.TabIndex = 104
        Me.picBrick38.TabStop = False
        '
        'picBrick7
        '
        Me.picBrick7.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick7.Location = New System.Drawing.Point(279, 56)
        Me.picBrick7.Name = "picBrick7"
        Me.picBrick7.Size = New System.Drawing.Size(21, 28)
        Me.picBrick7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick7.TabIndex = 103
        Me.picBrick7.TabStop = False
        '
        'picBrick6
        '
        Me.picBrick6.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick6.Location = New System.Drawing.Point(258, 56)
        Me.picBrick6.Name = "picBrick6"
        Me.picBrick6.Size = New System.Drawing.Size(21, 28)
        Me.picBrick6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick6.TabIndex = 102
        Me.picBrick6.TabStop = False
        '
        'picBrick45
        '
        Me.picBrick45.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick45.Location = New System.Drawing.Point(153, 336)
        Me.picBrick45.Name = "picBrick45"
        Me.picBrick45.Size = New System.Drawing.Size(21, 28)
        Me.picBrick45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick45.TabIndex = 101
        Me.picBrick45.TabStop = False
        '
        'picBrick44
        '
        Me.picBrick44.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick44.Location = New System.Drawing.Point(132, 336)
        Me.picBrick44.Name = "picBrick44"
        Me.picBrick44.Size = New System.Drawing.Size(21, 28)
        Me.picBrick44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick44.TabIndex = 100
        Me.picBrick44.TabStop = False
        '
        'picBrick43
        '
        Me.picBrick43.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick43.Location = New System.Drawing.Point(111, 336)
        Me.picBrick43.Name = "picBrick43"
        Me.picBrick43.Size = New System.Drawing.Size(21, 28)
        Me.picBrick43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick43.TabIndex = 99
        Me.picBrick43.TabStop = False
        '
        'picBrick42
        '
        Me.picBrick42.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick42.Location = New System.Drawing.Point(90, 336)
        Me.picBrick42.Name = "picBrick42"
        Me.picBrick42.Size = New System.Drawing.Size(21, 28)
        Me.picBrick42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick42.TabIndex = 98
        Me.picBrick42.TabStop = False
        '
        'picBrick54
        '
        Me.picBrick54.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick54.Location = New System.Drawing.Point(90, 392)
        Me.picBrick54.Name = "picBrick54"
        Me.picBrick54.Size = New System.Drawing.Size(21, 28)
        Me.picBrick54.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick54.TabIndex = 97
        Me.picBrick54.TabStop = False
        '
        'picBrick53
        '
        Me.picBrick53.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick53.Location = New System.Drawing.Point(69, 392)
        Me.picBrick53.Name = "picBrick53"
        Me.picBrick53.Size = New System.Drawing.Size(21, 28)
        Me.picBrick53.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick53.TabIndex = 96
        Me.picBrick53.TabStop = False
        '
        'picBrick52
        '
        Me.picBrick52.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick52.Location = New System.Drawing.Point(48, 392)
        Me.picBrick52.Name = "picBrick52"
        Me.picBrick52.Size = New System.Drawing.Size(21, 28)
        Me.picBrick52.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick52.TabIndex = 95
        Me.picBrick52.TabStop = False
        '
        'picBrick50
        '
        Me.picBrick50.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick50.Location = New System.Drawing.Point(195, 364)
        Me.picBrick50.Name = "picBrick50"
        Me.picBrick50.Size = New System.Drawing.Size(21, 28)
        Me.picBrick50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick50.TabIndex = 94
        Me.picBrick50.TabStop = False
        '
        'picBrick46
        '
        Me.picBrick46.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick46.Location = New System.Drawing.Point(195, 336)
        Me.picBrick46.Name = "picBrick46"
        Me.picBrick46.Size = New System.Drawing.Size(21, 28)
        Me.picBrick46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick46.TabIndex = 93
        Me.picBrick46.TabStop = False
        '
        'picBrick40
        '
        Me.picBrick40.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick40.Location = New System.Drawing.Point(195, 308)
        Me.picBrick40.Name = "picBrick40"
        Me.picBrick40.Size = New System.Drawing.Size(21, 28)
        Me.picBrick40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick40.TabIndex = 92
        Me.picBrick40.TabStop = False
        '
        'picBrick55
        '
        Me.picBrick55.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick55.Location = New System.Drawing.Point(153, 392)
        Me.picBrick55.Name = "picBrick55"
        Me.picBrick55.Size = New System.Drawing.Size(21, 28)
        Me.picBrick55.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick55.TabIndex = 91
        Me.picBrick55.TabStop = False
        '
        'picBrick49
        '
        Me.picBrick49.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick49.Location = New System.Drawing.Point(153, 364)
        Me.picBrick49.Name = "picBrick49"
        Me.picBrick49.Size = New System.Drawing.Size(21, 28)
        Me.picBrick49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick49.TabIndex = 90
        Me.picBrick49.TabStop = False
        '
        'picBrick59
        '
        Me.picBrick59.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick59.Location = New System.Drawing.Point(153, 420)
        Me.picBrick59.Name = "picBrick59"
        Me.picBrick59.Size = New System.Drawing.Size(21, 28)
        Me.picBrick59.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick59.TabIndex = 89
        Me.picBrick59.TabStop = False
        '
        'picBrick67
        '
        Me.picBrick67.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick67.Location = New System.Drawing.Point(237, 448)
        Me.picBrick67.Name = "picBrick67"
        Me.picBrick67.Size = New System.Drawing.Size(21, 28)
        Me.picBrick67.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick67.TabIndex = 88
        Me.picBrick67.TabStop = False
        '
        'picBrick66
        '
        Me.picBrick66.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick66.Location = New System.Drawing.Point(216, 448)
        Me.picBrick66.Name = "picBrick66"
        Me.picBrick66.Size = New System.Drawing.Size(21, 28)
        Me.picBrick66.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick66.TabIndex = 87
        Me.picBrick66.TabStop = False
        '
        'picBrick65
        '
        Me.picBrick65.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick65.Location = New System.Drawing.Point(174, 448)
        Me.picBrick65.Name = "picBrick65"
        Me.picBrick65.Size = New System.Drawing.Size(21, 28)
        Me.picBrick65.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick65.TabIndex = 86
        Me.picBrick65.TabStop = False
        '
        'picBrick64
        '
        Me.picBrick64.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick64.Location = New System.Drawing.Point(153, 448)
        Me.picBrick64.Name = "picBrick64"
        Me.picBrick64.Size = New System.Drawing.Size(21, 28)
        Me.picBrick64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick64.TabIndex = 85
        Me.picBrick64.TabStop = False
        '
        'picBrick41
        '
        Me.picBrick41.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick41.Location = New System.Drawing.Point(279, 308)
        Me.picBrick41.Name = "picBrick41"
        Me.picBrick41.Size = New System.Drawing.Size(21, 28)
        Me.picBrick41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick41.TabIndex = 84
        Me.picBrick41.TabStop = False
        '
        'picBrick37
        '
        Me.picBrick37.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick37.Location = New System.Drawing.Point(279, 280)
        Me.picBrick37.Name = "picBrick37"
        Me.picBrick37.Size = New System.Drawing.Size(21, 28)
        Me.picBrick37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick37.TabIndex = 83
        Me.picBrick37.TabStop = False
        '
        'picBrick48
        '
        Me.picBrick48.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick48.Location = New System.Drawing.Point(279, 336)
        Me.picBrick48.Name = "picBrick48"
        Me.picBrick48.Size = New System.Drawing.Size(21, 28)
        Me.picBrick48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick48.TabIndex = 82
        Me.picBrick48.TabStop = False
        '
        'picBrick36
        '
        Me.picBrick36.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick36.Location = New System.Drawing.Point(258, 280)
        Me.picBrick36.Name = "picBrick36"
        Me.picBrick36.Size = New System.Drawing.Size(21, 28)
        Me.picBrick36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick36.TabIndex = 81
        Me.picBrick36.TabStop = False
        '
        'picBrick35
        '
        Me.picBrick35.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick35.Location = New System.Drawing.Point(237, 280)
        Me.picBrick35.Name = "picBrick35"
        Me.picBrick35.Size = New System.Drawing.Size(21, 28)
        Me.picBrick35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick35.TabIndex = 80
        Me.picBrick35.TabStop = False
        '
        'picBrick34
        '
        Me.picBrick34.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick34.Location = New System.Drawing.Point(216, 280)
        Me.picBrick34.Name = "picBrick34"
        Me.picBrick34.Size = New System.Drawing.Size(21, 28)
        Me.picBrick34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick34.TabIndex = 79
        Me.picBrick34.TabStop = False
        '
        'picBrick15
        '
        Me.picBrick15.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick15.Location = New System.Drawing.Point(195, 112)
        Me.picBrick15.Name = "picBrick15"
        Me.picBrick15.Size = New System.Drawing.Size(21, 28)
        Me.picBrick15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick15.TabIndex = 78
        Me.picBrick15.TabStop = False
        '
        'picBrick9
        '
        Me.picBrick9.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick9.Location = New System.Drawing.Point(195, 84)
        Me.picBrick9.Name = "picBrick9"
        Me.picBrick9.Size = New System.Drawing.Size(21, 28)
        Me.picBrick9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick9.TabIndex = 77
        Me.picBrick9.TabStop = False
        '
        'picBrick29
        '
        Me.picBrick29.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick29.Location = New System.Drawing.Point(153, 224)
        Me.picBrick29.Name = "picBrick29"
        Me.picBrick29.Size = New System.Drawing.Size(21, 28)
        Me.picBrick29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick29.TabIndex = 76
        Me.picBrick29.TabStop = False
        '
        'picBrick23
        '
        Me.picBrick23.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick23.Location = New System.Drawing.Point(153, 196)
        Me.picBrick23.Name = "picBrick23"
        Me.picBrick23.Size = New System.Drawing.Size(21, 28)
        Me.picBrick23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick23.TabIndex = 75
        Me.picBrick23.TabStop = False
        '
        'picBrick5
        '
        Me.picBrick5.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick5.Location = New System.Drawing.Point(195, 56)
        Me.picBrick5.Name = "picBrick5"
        Me.picBrick5.Size = New System.Drawing.Size(21, 28)
        Me.picBrick5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick5.TabIndex = 74
        Me.picBrick5.TabStop = False
        '
        'picBrick4
        '
        Me.picBrick4.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick4.Location = New System.Drawing.Point(174, 56)
        Me.picBrick4.Name = "picBrick4"
        Me.picBrick4.Size = New System.Drawing.Size(21, 28)
        Me.picBrick4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick4.TabIndex = 73
        Me.picBrick4.TabStop = False
        '
        'picBrick33
        '
        Me.picBrick33.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick33.Location = New System.Drawing.Point(153, 280)
        Me.picBrick33.Name = "picBrick33"
        Me.picBrick33.Size = New System.Drawing.Size(21, 28)
        Me.picBrick33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick33.TabIndex = 72
        Me.picBrick33.TabStop = False
        '
        'picBrick32
        '
        Me.picBrick32.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick32.Location = New System.Drawing.Point(132, 280)
        Me.picBrick32.Name = "picBrick32"
        Me.picBrick32.Size = New System.Drawing.Size(21, 28)
        Me.picBrick32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick32.TabIndex = 71
        Me.picBrick32.TabStop = False
        '
        'picBrick8
        '
        Me.picBrick8.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick8.Location = New System.Drawing.Point(153, 84)
        Me.picBrick8.Name = "picBrick8"
        Me.picBrick8.Size = New System.Drawing.Size(21, 28)
        Me.picBrick8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick8.TabIndex = 70
        Me.picBrick8.TabStop = False
        '
        'picBrick3
        '
        Me.picBrick3.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick3.Location = New System.Drawing.Point(153, 56)
        Me.picBrick3.Name = "picBrick3"
        Me.picBrick3.Size = New System.Drawing.Size(21, 28)
        Me.picBrick3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick3.TabIndex = 69
        Me.picBrick3.TabStop = False
        '
        'picBrick14
        '
        Me.picBrick14.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick14.Location = New System.Drawing.Point(153, 112)
        Me.picBrick14.Name = "picBrick14"
        Me.picBrick14.Size = New System.Drawing.Size(21, 28)
        Me.picBrick14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick14.TabIndex = 68
        Me.picBrick14.TabStop = False
        '
        'picBrick13
        '
        Me.picBrick13.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick13.Location = New System.Drawing.Point(132, 112)
        Me.picBrick13.Name = "picBrick13"
        Me.picBrick13.Size = New System.Drawing.Size(21, 28)
        Me.picBrick13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick13.TabIndex = 67
        Me.picBrick13.TabStop = False
        '
        'picBrick26
        '
        Me.picBrick26.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick26.Location = New System.Drawing.Point(48, 224)
        Me.picBrick26.Name = "picBrick26"
        Me.picBrick26.Size = New System.Drawing.Size(21, 28)
        Me.picBrick26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick26.TabIndex = 66
        Me.picBrick26.TabStop = False
        '
        'picBrick39
        '
        Me.picBrick39.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick39.Location = New System.Drawing.Point(69, 308)
        Me.picBrick39.Name = "picBrick39"
        Me.picBrick39.Size = New System.Drawing.Size(21, 28)
        Me.picBrick39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick39.TabIndex = 65
        Me.picBrick39.TabStop = False
        '
        'picBrick25
        '
        Me.picBrick25.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick25.Location = New System.Drawing.Point(27, 224)
        Me.picBrick25.Name = "picBrick25"
        Me.picBrick25.Size = New System.Drawing.Size(21, 28)
        Me.picBrick25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick25.TabIndex = 64
        Me.picBrick25.TabStop = False
        '
        'picBrick31
        '
        Me.picBrick31.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick31.Location = New System.Drawing.Point(237, 224)
        Me.picBrick31.Name = "picBrick31"
        Me.picBrick31.Size = New System.Drawing.Size(21, 28)
        Me.picBrick31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick31.TabIndex = 63
        Me.picBrick31.TabStop = False
        '
        'picBrick30
        '
        Me.picBrick30.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick30.Location = New System.Drawing.Point(216, 224)
        Me.picBrick30.Name = "picBrick30"
        Me.picBrick30.Size = New System.Drawing.Size(21, 28)
        Me.picBrick30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick30.TabIndex = 62
        Me.picBrick30.TabStop = False
        '
        'picBrick28
        '
        Me.picBrick28.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick28.Location = New System.Drawing.Point(111, 224)
        Me.picBrick28.Name = "picBrick28"
        Me.picBrick28.Size = New System.Drawing.Size(21, 28)
        Me.picBrick28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick28.TabIndex = 61
        Me.picBrick28.TabStop = False
        '
        'picBrick27
        '
        Me.picBrick27.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick27.Location = New System.Drawing.Point(90, 224)
        Me.picBrick27.Name = "picBrick27"
        Me.picBrick27.Size = New System.Drawing.Size(21, 28)
        Me.picBrick27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick27.TabIndex = 60
        Me.picBrick27.TabStop = False
        '
        'picBrick16
        '
        Me.picBrick16.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick16.Location = New System.Drawing.Point(69, 140)
        Me.picBrick16.Name = "picBrick16"
        Me.picBrick16.Size = New System.Drawing.Size(21, 28)
        Me.picBrick16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick16.TabIndex = 59
        Me.picBrick16.TabStop = False
        '
        'picBrick12
        '
        Me.picBrick12.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick12.Location = New System.Drawing.Point(90, 112)
        Me.picBrick12.Name = "picBrick12"
        Me.picBrick12.Size = New System.Drawing.Size(21, 28)
        Me.picBrick12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick12.TabIndex = 58
        Me.picBrick12.TabStop = False
        '
        'picBrick11
        '
        Me.picBrick11.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick11.Location = New System.Drawing.Point(69, 112)
        Me.picBrick11.Name = "picBrick11"
        Me.picBrick11.Size = New System.Drawing.Size(21, 28)
        Me.picBrick11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick11.TabIndex = 57
        Me.picBrick11.TabStop = False
        '
        'picBrick10
        '
        Me.picBrick10.Image = Global.Bomberman.My.Resources.Resources.bomberman_brick
        Me.picBrick10.Location = New System.Drawing.Point(48, 112)
        Me.picBrick10.Name = "picBrick10"
        Me.picBrick10.Size = New System.Drawing.Size(21, 28)
        Me.picBrick10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrick10.TabIndex = 56
        Me.picBrick10.TabStop = False
        '
        'picBomberman2
        '
        Me.picBomberman2.Image = Global.Bomberman.My.Resources.Resources.bomberman_2_up
        Me.picBomberman2.Location = New System.Drawing.Point(279, 504)
        Me.picBomberman2.Name = "picBomberman2"
        Me.picBomberman2.Size = New System.Drawing.Size(21, 28)
        Me.picBomberman2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBomberman2.TabIndex = 54
        Me.picBomberman2.TabStop = False
        '
        'picMetal48
        '
        Me.picMetal48.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal48.Location = New System.Drawing.Point(258, 476)
        Me.picMetal48.Name = "picMetal48"
        Me.picMetal48.Size = New System.Drawing.Size(21, 28)
        Me.picMetal48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal48.TabIndex = 53
        Me.picMetal48.TabStop = False
        '
        'picMetal47
        '
        Me.picMetal47.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal47.Location = New System.Drawing.Point(216, 476)
        Me.picMetal47.Name = "picMetal47"
        Me.picMetal47.Size = New System.Drawing.Size(21, 28)
        Me.picMetal47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal47.TabIndex = 52
        Me.picMetal47.TabStop = False
        '
        'picMetal46
        '
        Me.picMetal46.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal46.Location = New System.Drawing.Point(174, 476)
        Me.picMetal46.Name = "picMetal46"
        Me.picMetal46.Size = New System.Drawing.Size(21, 28)
        Me.picMetal46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal46.TabIndex = 51
        Me.picMetal46.TabStop = False
        '
        'picMetal45
        '
        Me.picMetal45.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal45.Location = New System.Drawing.Point(132, 476)
        Me.picMetal45.Name = "picMetal45"
        Me.picMetal45.Size = New System.Drawing.Size(21, 28)
        Me.picMetal45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal45.TabIndex = 50
        Me.picMetal45.TabStop = False
        '
        'picMetal44
        '
        Me.picMetal44.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal44.Location = New System.Drawing.Point(90, 476)
        Me.picMetal44.Name = "picMetal44"
        Me.picMetal44.Size = New System.Drawing.Size(21, 28)
        Me.picMetal44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal44.TabIndex = 49
        Me.picMetal44.TabStop = False
        '
        'picMetal43
        '
        Me.picMetal43.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal43.Location = New System.Drawing.Point(48, 476)
        Me.picMetal43.Name = "picMetal43"
        Me.picMetal43.Size = New System.Drawing.Size(21, 28)
        Me.picMetal43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal43.TabIndex = 48
        Me.picMetal43.TabStop = False
        '
        'picMetal42
        '
        Me.picMetal42.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal42.Location = New System.Drawing.Point(258, 420)
        Me.picMetal42.Name = "picMetal42"
        Me.picMetal42.Size = New System.Drawing.Size(21, 28)
        Me.picMetal42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal42.TabIndex = 47
        Me.picMetal42.TabStop = False
        '
        'picMetal41
        '
        Me.picMetal41.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal41.Location = New System.Drawing.Point(216, 420)
        Me.picMetal41.Name = "picMetal41"
        Me.picMetal41.Size = New System.Drawing.Size(21, 28)
        Me.picMetal41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal41.TabIndex = 46
        Me.picMetal41.TabStop = False
        '
        'picMetal40
        '
        Me.picMetal40.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal40.Location = New System.Drawing.Point(174, 420)
        Me.picMetal40.Name = "picMetal40"
        Me.picMetal40.Size = New System.Drawing.Size(21, 28)
        Me.picMetal40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal40.TabIndex = 45
        Me.picMetal40.TabStop = False
        '
        'picMetal39
        '
        Me.picMetal39.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal39.Location = New System.Drawing.Point(132, 420)
        Me.picMetal39.Name = "picMetal39"
        Me.picMetal39.Size = New System.Drawing.Size(21, 28)
        Me.picMetal39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal39.TabIndex = 44
        Me.picMetal39.TabStop = False
        '
        'picMetal38
        '
        Me.picMetal38.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal38.Location = New System.Drawing.Point(90, 420)
        Me.picMetal38.Name = "picMetal38"
        Me.picMetal38.Size = New System.Drawing.Size(21, 28)
        Me.picMetal38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal38.TabIndex = 43
        Me.picMetal38.TabStop = False
        '
        'picMetal37
        '
        Me.picMetal37.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal37.Location = New System.Drawing.Point(48, 420)
        Me.picMetal37.Name = "picMetal37"
        Me.picMetal37.Size = New System.Drawing.Size(21, 28)
        Me.picMetal37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal37.TabIndex = 42
        Me.picMetal37.TabStop = False
        '
        'picMetal36
        '
        Me.picMetal36.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal36.Location = New System.Drawing.Point(258, 364)
        Me.picMetal36.Name = "picMetal36"
        Me.picMetal36.Size = New System.Drawing.Size(21, 28)
        Me.picMetal36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal36.TabIndex = 41
        Me.picMetal36.TabStop = False
        '
        'picMetal35
        '
        Me.picMetal35.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal35.Location = New System.Drawing.Point(216, 364)
        Me.picMetal35.Name = "picMetal35"
        Me.picMetal35.Size = New System.Drawing.Size(21, 28)
        Me.picMetal35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal35.TabIndex = 40
        Me.picMetal35.TabStop = False
        '
        'picMetal34
        '
        Me.picMetal34.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal34.Location = New System.Drawing.Point(174, 364)
        Me.picMetal34.Name = "picMetal34"
        Me.picMetal34.Size = New System.Drawing.Size(21, 28)
        Me.picMetal34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal34.TabIndex = 39
        Me.picMetal34.TabStop = False
        '
        'picMetal33
        '
        Me.picMetal33.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal33.Location = New System.Drawing.Point(132, 364)
        Me.picMetal33.Name = "picMetal33"
        Me.picMetal33.Size = New System.Drawing.Size(21, 28)
        Me.picMetal33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal33.TabIndex = 38
        Me.picMetal33.TabStop = False
        '
        'picMetal32
        '
        Me.picMetal32.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal32.Location = New System.Drawing.Point(90, 364)
        Me.picMetal32.Name = "picMetal32"
        Me.picMetal32.Size = New System.Drawing.Size(21, 28)
        Me.picMetal32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal32.TabIndex = 37
        Me.picMetal32.TabStop = False
        '
        'picMetal31
        '
        Me.picMetal31.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal31.Location = New System.Drawing.Point(48, 364)
        Me.picMetal31.Name = "picMetal31"
        Me.picMetal31.Size = New System.Drawing.Size(21, 28)
        Me.picMetal31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal31.TabIndex = 36
        Me.picMetal31.TabStop = False
        '
        'picMetal30
        '
        Me.picMetal30.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal30.Location = New System.Drawing.Point(258, 308)
        Me.picMetal30.Name = "picMetal30"
        Me.picMetal30.Size = New System.Drawing.Size(21, 28)
        Me.picMetal30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal30.TabIndex = 35
        Me.picMetal30.TabStop = False
        '
        'picMetal29
        '
        Me.picMetal29.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal29.Location = New System.Drawing.Point(216, 308)
        Me.picMetal29.Name = "picMetal29"
        Me.picMetal29.Size = New System.Drawing.Size(21, 28)
        Me.picMetal29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal29.TabIndex = 34
        Me.picMetal29.TabStop = False
        '
        'picMetal28
        '
        Me.picMetal28.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal28.Location = New System.Drawing.Point(174, 308)
        Me.picMetal28.Name = "picMetal28"
        Me.picMetal28.Size = New System.Drawing.Size(21, 28)
        Me.picMetal28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal28.TabIndex = 33
        Me.picMetal28.TabStop = False
        '
        'picMetal27
        '
        Me.picMetal27.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal27.Location = New System.Drawing.Point(132, 308)
        Me.picMetal27.Name = "picMetal27"
        Me.picMetal27.Size = New System.Drawing.Size(21, 28)
        Me.picMetal27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal27.TabIndex = 32
        Me.picMetal27.TabStop = False
        '
        'picMetal26
        '
        Me.picMetal26.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal26.Location = New System.Drawing.Point(90, 308)
        Me.picMetal26.Name = "picMetal26"
        Me.picMetal26.Size = New System.Drawing.Size(21, 28)
        Me.picMetal26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal26.TabIndex = 31
        Me.picMetal26.TabStop = False
        '
        'picMetal25
        '
        Me.picMetal25.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal25.Location = New System.Drawing.Point(48, 308)
        Me.picMetal25.Name = "picMetal25"
        Me.picMetal25.Size = New System.Drawing.Size(21, 28)
        Me.picMetal25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal25.TabIndex = 30
        Me.picMetal25.TabStop = False
        '
        'picMetal24
        '
        Me.picMetal24.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal24.Location = New System.Drawing.Point(258, 252)
        Me.picMetal24.Name = "picMetal24"
        Me.picMetal24.Size = New System.Drawing.Size(21, 28)
        Me.picMetal24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal24.TabIndex = 29
        Me.picMetal24.TabStop = False
        '
        'picMetal23
        '
        Me.picMetal23.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal23.Location = New System.Drawing.Point(216, 252)
        Me.picMetal23.Name = "picMetal23"
        Me.picMetal23.Size = New System.Drawing.Size(21, 28)
        Me.picMetal23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal23.TabIndex = 28
        Me.picMetal23.TabStop = False
        '
        'picMetal22
        '
        Me.picMetal22.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal22.Location = New System.Drawing.Point(174, 252)
        Me.picMetal22.Name = "picMetal22"
        Me.picMetal22.Size = New System.Drawing.Size(21, 28)
        Me.picMetal22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal22.TabIndex = 27
        Me.picMetal22.TabStop = False
        '
        'picMetal21
        '
        Me.picMetal21.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal21.Location = New System.Drawing.Point(132, 252)
        Me.picMetal21.Name = "picMetal21"
        Me.picMetal21.Size = New System.Drawing.Size(21, 28)
        Me.picMetal21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal21.TabIndex = 26
        Me.picMetal21.TabStop = False
        '
        'picMetal20
        '
        Me.picMetal20.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal20.Location = New System.Drawing.Point(90, 252)
        Me.picMetal20.Name = "picMetal20"
        Me.picMetal20.Size = New System.Drawing.Size(21, 28)
        Me.picMetal20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal20.TabIndex = 25
        Me.picMetal20.TabStop = False
        '
        'picMetal19
        '
        Me.picMetal19.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal19.Location = New System.Drawing.Point(48, 252)
        Me.picMetal19.Name = "picMetal19"
        Me.picMetal19.Size = New System.Drawing.Size(21, 28)
        Me.picMetal19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal19.TabIndex = 24
        Me.picMetal19.TabStop = False
        '
        'picMetal18
        '
        Me.picMetal18.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal18.Location = New System.Drawing.Point(258, 196)
        Me.picMetal18.Name = "picMetal18"
        Me.picMetal18.Size = New System.Drawing.Size(21, 28)
        Me.picMetal18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal18.TabIndex = 23
        Me.picMetal18.TabStop = False
        '
        'picMetal17
        '
        Me.picMetal17.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal17.Location = New System.Drawing.Point(216, 196)
        Me.picMetal17.Name = "picMetal17"
        Me.picMetal17.Size = New System.Drawing.Size(21, 28)
        Me.picMetal17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal17.TabIndex = 22
        Me.picMetal17.TabStop = False
        '
        'picMetal16
        '
        Me.picMetal16.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal16.Location = New System.Drawing.Point(174, 196)
        Me.picMetal16.Name = "picMetal16"
        Me.picMetal16.Size = New System.Drawing.Size(21, 28)
        Me.picMetal16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal16.TabIndex = 21
        Me.picMetal16.TabStop = False
        '
        'picMetal15
        '
        Me.picMetal15.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal15.Location = New System.Drawing.Point(132, 196)
        Me.picMetal15.Name = "picMetal15"
        Me.picMetal15.Size = New System.Drawing.Size(21, 28)
        Me.picMetal15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal15.TabIndex = 20
        Me.picMetal15.TabStop = False
        '
        'picMetal14
        '
        Me.picMetal14.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal14.Location = New System.Drawing.Point(90, 196)
        Me.picMetal14.Name = "picMetal14"
        Me.picMetal14.Size = New System.Drawing.Size(21, 28)
        Me.picMetal14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal14.TabIndex = 19
        Me.picMetal14.TabStop = False
        '
        'picMetal13
        '
        Me.picMetal13.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal13.Location = New System.Drawing.Point(48, 196)
        Me.picMetal13.Name = "picMetal13"
        Me.picMetal13.Size = New System.Drawing.Size(21, 28)
        Me.picMetal13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal13.TabIndex = 18
        Me.picMetal13.TabStop = False
        '
        'picMetal12
        '
        Me.picMetal12.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal12.Location = New System.Drawing.Point(258, 140)
        Me.picMetal12.Name = "picMetal12"
        Me.picMetal12.Size = New System.Drawing.Size(21, 28)
        Me.picMetal12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal12.TabIndex = 17
        Me.picMetal12.TabStop = False
        '
        'picMetal11
        '
        Me.picMetal11.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal11.Location = New System.Drawing.Point(216, 140)
        Me.picMetal11.Name = "picMetal11"
        Me.picMetal11.Size = New System.Drawing.Size(21, 28)
        Me.picMetal11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal11.TabIndex = 16
        Me.picMetal11.TabStop = False
        '
        'picMetal10
        '
        Me.picMetal10.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal10.Location = New System.Drawing.Point(174, 140)
        Me.picMetal10.Name = "picMetal10"
        Me.picMetal10.Size = New System.Drawing.Size(21, 28)
        Me.picMetal10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal10.TabIndex = 15
        Me.picMetal10.TabStop = False
        '
        'picMetal9
        '
        Me.picMetal9.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal9.Location = New System.Drawing.Point(132, 140)
        Me.picMetal9.Name = "picMetal9"
        Me.picMetal9.Size = New System.Drawing.Size(21, 28)
        Me.picMetal9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal9.TabIndex = 14
        Me.picMetal9.TabStop = False
        '
        'picMetal8
        '
        Me.picMetal8.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal8.Location = New System.Drawing.Point(90, 140)
        Me.picMetal8.Name = "picMetal8"
        Me.picMetal8.Size = New System.Drawing.Size(21, 28)
        Me.picMetal8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal8.TabIndex = 13
        Me.picMetal8.TabStop = False
        '
        'picMetal7
        '
        Me.picMetal7.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal7.Location = New System.Drawing.Point(48, 140)
        Me.picMetal7.Name = "picMetal7"
        Me.picMetal7.Size = New System.Drawing.Size(21, 28)
        Me.picMetal7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal7.TabIndex = 12
        Me.picMetal7.TabStop = False
        '
        'picMetal6
        '
        Me.picMetal6.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal6.Location = New System.Drawing.Point(258, 84)
        Me.picMetal6.Name = "picMetal6"
        Me.picMetal6.Size = New System.Drawing.Size(21, 28)
        Me.picMetal6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal6.TabIndex = 11
        Me.picMetal6.TabStop = False
        '
        'picMetal5
        '
        Me.picMetal5.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal5.Location = New System.Drawing.Point(216, 84)
        Me.picMetal5.Name = "picMetal5"
        Me.picMetal5.Size = New System.Drawing.Size(21, 28)
        Me.picMetal5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal5.TabIndex = 10
        Me.picMetal5.TabStop = False
        '
        'picMetal4
        '
        Me.picMetal4.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal4.Location = New System.Drawing.Point(174, 84)
        Me.picMetal4.Name = "picMetal4"
        Me.picMetal4.Size = New System.Drawing.Size(21, 28)
        Me.picMetal4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal4.TabIndex = 9
        Me.picMetal4.TabStop = False
        '
        'picMetal3
        '
        Me.picMetal3.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal3.Location = New System.Drawing.Point(132, 84)
        Me.picMetal3.Name = "picMetal3"
        Me.picMetal3.Size = New System.Drawing.Size(21, 28)
        Me.picMetal3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal3.TabIndex = 8
        Me.picMetal3.TabStop = False
        '
        'picMetal2
        '
        Me.picMetal2.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal2.Location = New System.Drawing.Point(90, 84)
        Me.picMetal2.Name = "picMetal2"
        Me.picMetal2.Size = New System.Drawing.Size(21, 28)
        Me.picMetal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal2.TabIndex = 7
        Me.picMetal2.TabStop = False
        '
        'picBomberman1
        '
        Me.picBomberman1.Image = Global.Bomberman.My.Resources.Resources.bomberman_1_down
        Me.picBomberman1.Location = New System.Drawing.Point(27, 56)
        Me.picBomberman1.Name = "picBomberman1"
        Me.picBomberman1.Size = New System.Drawing.Size(21, 28)
        Me.picBomberman1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBomberman1.TabIndex = 6
        Me.picBomberman1.TabStop = False
        '
        'picMetal
        '
        Me.picMetal.Image = Global.Bomberman.My.Resources.Resources.bomberman_block
        Me.picMetal.Location = New System.Drawing.Point(48, 84)
        Me.picMetal.Name = "picMetal"
        Me.picMetal.Size = New System.Drawing.Size(21, 28)
        Me.picMetal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMetal.TabIndex = 5
        Me.picMetal.TabStop = False
        '
        'picFrameRight
        '
        Me.picFrameRight.BackColor = System.Drawing.Color.Gray
        Me.picFrameRight.Location = New System.Drawing.Point(300, 19)
        Me.picFrameRight.Name = "picFrameRight"
        Me.picFrameRight.Size = New System.Drawing.Size(32, 579)
        Me.picFrameRight.TabIndex = 4
        Me.picFrameRight.TabStop = False
        '
        'picFrameBottom
        '
        Me.picFrameBottom.BackColor = System.Drawing.Color.Gray
        Me.picFrameBottom.Location = New System.Drawing.Point(-13, 532)
        Me.picFrameBottom.Name = "picFrameBottom"
        Me.picFrameBottom.Size = New System.Drawing.Size(361, 45)
        Me.picFrameBottom.TabIndex = 3
        Me.picFrameBottom.TabStop = False
        '
        'picFrameLeft
        '
        Me.picFrameLeft.BackColor = System.Drawing.Color.Gray
        Me.picFrameLeft.Location = New System.Drawing.Point(-1, 41)
        Me.picFrameLeft.Name = "picFrameLeft"
        Me.picFrameLeft.Size = New System.Drawing.Size(28, 557)
        Me.picFrameLeft.TabIndex = 2
        Me.picFrameLeft.TabStop = False
        '
        'picFrameTop
        '
        Me.picFrameTop.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picFrameTop.Location = New System.Drawing.Point(-24, 27)
        Me.picFrameTop.Name = "picFrameTop"
        Me.picFrameTop.Size = New System.Drawing.Size(370, 29)
        Me.picFrameTop.TabIndex = 1
        Me.picFrameTop.TabStop = False
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(330, 559)
        Me.Controls.Add(Me.picBomb2)
        Me.Controls.Add(Me.picExplode2)
        Me.Controls.Add(Me.picExplodeDown6)
        Me.Controls.Add(Me.picExplodeDown5)
        Me.Controls.Add(Me.picExplodeUp5)
        Me.Controls.Add(Me.picExplodeUp6)
        Me.Controls.Add(Me.picExplodeLeft5)
        Me.Controls.Add(Me.picExplodeLeft6)
        Me.Controls.Add(Me.picExplodeRight6)
        Me.Controls.Add(Me.picExplodeRight5)
        Me.Controls.Add(Me.picBomb1)
        Me.Controls.Add(Me.picExplode1)
        Me.Controls.Add(Me.picExplodeDown4)
        Me.Controls.Add(Me.picExplodeDown2)
        Me.Controls.Add(Me.picExplodeDown3)
        Me.Controls.Add(Me.picExplodeDown)
        Me.Controls.Add(Me.picExplodeUp4)
        Me.Controls.Add(Me.picExplodeUp2)
        Me.Controls.Add(Me.picExplodeUp3)
        Me.Controls.Add(Me.picExplodeUp)
        Me.Controls.Add(Me.picExplodeRight4)
        Me.Controls.Add(Me.picExplodeRight3)
        Me.Controls.Add(Me.picExplodeRight)
        Me.Controls.Add(Me.picExplodeRight2)
        Me.Controls.Add(Me.picExplodeLeft4)
        Me.Controls.Add(Me.picExplodeLeft3)
        Me.Controls.Add(Me.picExplodeLeft2)
        Me.Controls.Add(Me.picExplodeLeft)
        Me.Controls.Add(Me.picFire1)
        Me.Controls.Add(Me.picFire2)
        Me.Controls.Add(Me.picBrick21)
        Me.Controls.Add(Me.picBrick73)
        Me.Controls.Add(Me.picBrick24)
        Me.Controls.Add(Me.picBrick22)
        Me.Controls.Add(Me.picBrick17)
        Me.Controls.Add(Me.picBrick58)
        Me.Controls.Add(Me.picBrick2)
        Me.Controls.Add(Me.picBrick1)
        Me.Controls.Add(Me.picBrick60)
        Me.Controls.Add(Me.picBrick57)
        Me.Controls.Add(Me.picBrick72)
        Me.Controls.Add(Me.picBrick71)
        Me.Controls.Add(Me.picBrick70)
        Me.Controls.Add(Me.picBrick20)
        Me.Controls.Add(Me.picBrick19)
        Me.Controls.Add(Me.picBrick18)
        Me.Controls.Add(Me.picBrick47)
        Me.Controls.Add(Me.picBrick51)
        Me.Controls.Add(Me.picBrick56)
        Me.Controls.Add(Me.picBrick63)
        Me.Controls.Add(Me.picBrick62)
        Me.Controls.Add(Me.picBrick61)
        Me.Controls.Add(Me.picBrick69)
        Me.Controls.Add(Me.picBrick68)
        Me.Controls.Add(Me.picBrick38)
        Me.Controls.Add(Me.picBrick7)
        Me.Controls.Add(Me.picBrick6)
        Me.Controls.Add(Me.picBrick45)
        Me.Controls.Add(Me.picBrick44)
        Me.Controls.Add(Me.picBrick43)
        Me.Controls.Add(Me.picBrick42)
        Me.Controls.Add(Me.picBrick54)
        Me.Controls.Add(Me.picBrick53)
        Me.Controls.Add(Me.picBrick52)
        Me.Controls.Add(Me.picBrick50)
        Me.Controls.Add(Me.picBrick46)
        Me.Controls.Add(Me.picBrick40)
        Me.Controls.Add(Me.picBrick55)
        Me.Controls.Add(Me.picBrick49)
        Me.Controls.Add(Me.picBrick59)
        Me.Controls.Add(Me.picBrick67)
        Me.Controls.Add(Me.picBrick66)
        Me.Controls.Add(Me.picBrick65)
        Me.Controls.Add(Me.picBrick64)
        Me.Controls.Add(Me.picBrick41)
        Me.Controls.Add(Me.picBrick37)
        Me.Controls.Add(Me.picBrick48)
        Me.Controls.Add(Me.picBrick36)
        Me.Controls.Add(Me.picBrick35)
        Me.Controls.Add(Me.picBrick34)
        Me.Controls.Add(Me.picBrick15)
        Me.Controls.Add(Me.picBrick9)
        Me.Controls.Add(Me.picBrick29)
        Me.Controls.Add(Me.picBrick23)
        Me.Controls.Add(Me.picBrick5)
        Me.Controls.Add(Me.picBrick4)
        Me.Controls.Add(Me.picBrick33)
        Me.Controls.Add(Me.picBrick32)
        Me.Controls.Add(Me.picBrick8)
        Me.Controls.Add(Me.picBrick3)
        Me.Controls.Add(Me.picBrick14)
        Me.Controls.Add(Me.picBrick13)
        Me.Controls.Add(Me.picBrick26)
        Me.Controls.Add(Me.picBrick39)
        Me.Controls.Add(Me.picBrick25)
        Me.Controls.Add(Me.picBrick31)
        Me.Controls.Add(Me.picBrick30)
        Me.Controls.Add(Me.picBrick28)
        Me.Controls.Add(Me.picBrick27)
        Me.Controls.Add(Me.picBrick16)
        Me.Controls.Add(Me.picBrick12)
        Me.Controls.Add(Me.picBrick11)
        Me.Controls.Add(Me.picBrick10)
        Me.Controls.Add(Me.picBomberman2)
        Me.Controls.Add(Me.picMetal48)
        Me.Controls.Add(Me.picMetal47)
        Me.Controls.Add(Me.picMetal46)
        Me.Controls.Add(Me.picMetal45)
        Me.Controls.Add(Me.picMetal44)
        Me.Controls.Add(Me.picMetal43)
        Me.Controls.Add(Me.picMetal42)
        Me.Controls.Add(Me.picMetal41)
        Me.Controls.Add(Me.picMetal40)
        Me.Controls.Add(Me.picMetal39)
        Me.Controls.Add(Me.picMetal38)
        Me.Controls.Add(Me.picMetal37)
        Me.Controls.Add(Me.picMetal36)
        Me.Controls.Add(Me.picMetal35)
        Me.Controls.Add(Me.picMetal34)
        Me.Controls.Add(Me.picMetal33)
        Me.Controls.Add(Me.picMetal32)
        Me.Controls.Add(Me.picMetal31)
        Me.Controls.Add(Me.picMetal30)
        Me.Controls.Add(Me.picMetal29)
        Me.Controls.Add(Me.picMetal28)
        Me.Controls.Add(Me.picMetal27)
        Me.Controls.Add(Me.picMetal26)
        Me.Controls.Add(Me.picMetal25)
        Me.Controls.Add(Me.picMetal24)
        Me.Controls.Add(Me.picMetal23)
        Me.Controls.Add(Me.picMetal22)
        Me.Controls.Add(Me.picMetal21)
        Me.Controls.Add(Me.picMetal20)
        Me.Controls.Add(Me.picMetal19)
        Me.Controls.Add(Me.picMetal18)
        Me.Controls.Add(Me.picMetal17)
        Me.Controls.Add(Me.picMetal16)
        Me.Controls.Add(Me.picMetal15)
        Me.Controls.Add(Me.picMetal14)
        Me.Controls.Add(Me.picMetal13)
        Me.Controls.Add(Me.picMetal12)
        Me.Controls.Add(Me.picMetal11)
        Me.Controls.Add(Me.picMetal10)
        Me.Controls.Add(Me.picMetal9)
        Me.Controls.Add(Me.picMetal8)
        Me.Controls.Add(Me.picMetal7)
        Me.Controls.Add(Me.picMetal6)
        Me.Controls.Add(Me.picMetal5)
        Me.Controls.Add(Me.picMetal4)
        Me.Controls.Add(Me.picMetal3)
        Me.Controls.Add(Me.picMetal2)
        Me.Controls.Add(Me.picBomberman1)
        Me.Controls.Add(Me.picMetal)
        Me.Controls.Add(Me.picFrameRight)
        Me.Controls.Add(Me.picFrameBottom)
        Me.Controls.Add(Me.picFrameLeft)
        Me.Controls.Add(Me.picFrameTop)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.Text = "Bomberman"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picBomb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeDown6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeDown5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeUp5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeUp6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeLeft5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeLeft6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeRight6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeRight5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBomb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplode1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeDown4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeUp4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeUp2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeUp3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeRight4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeRight3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeRight2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeLeft4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeLeft3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeLeft2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picExplodeLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFire1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFire2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick73, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick72, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick70, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick49, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrick10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBomberman2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBomberman1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMetal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrameRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrameBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrameLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrameTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picFrameTop As System.Windows.Forms.PictureBox
    Friend WithEvents picFrameLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picFrameBottom As System.Windows.Forms.PictureBox
    Friend WithEvents picFrameRight As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal As System.Windows.Forms.PictureBox
    Friend WithEvents picBomberman1 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal2 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal3 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal4 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal5 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal6 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal12 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal11 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal10 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal9 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal8 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal7 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal24 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal23 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal22 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal21 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal20 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal19 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal18 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal17 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal16 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal15 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal14 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal13 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal48 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal47 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal46 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal45 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal44 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal43 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal42 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal41 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal40 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal39 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal38 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal37 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal36 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal35 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal34 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal33 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal32 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal31 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal30 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal29 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal28 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal27 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal26 As System.Windows.Forms.PictureBox
    Friend WithEvents picMetal25 As System.Windows.Forms.PictureBox
    Friend WithEvents picBomberman2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick10 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick11 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick16 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick12 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick27 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick28 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick31 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick30 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick39 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick25 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick26 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick14 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick13 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick8 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick3 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick33 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick32 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick4 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick29 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick23 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick15 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick9 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick36 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick35 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick34 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick41 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick37 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick48 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick67 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick66 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick65 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick64 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick55 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick49 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick59 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick50 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick46 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick40 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick54 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick53 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick52 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick45 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick44 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick43 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick42 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick7 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick6 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick38 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick69 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick68 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick63 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick62 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick61 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick47 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick51 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick56 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick18 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick20 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick19 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick72 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick71 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick70 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick60 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick57 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick58 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick17 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick24 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick22 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick73 As System.Windows.Forms.PictureBox
    Friend WithEvents picBrick21 As System.Windows.Forms.PictureBox
    Friend WithEvents picFire2 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeLeft As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeLeft2 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeLeft3 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeLeft4 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeRight4 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeRight3 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeRight As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeRight2 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeUp As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeUp3 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeUp2 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeUp4 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeDown4 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeDown2 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeDown3 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeDown As System.Windows.Forms.PictureBox
    Friend WithEvents picExplode1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBomb1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrBomb As System.Windows.Forms.Timer
    Friend WithEvents tmrBomb2 As System.Windows.Forms.Timer
    Friend WithEvents tmrExplosion1 As System.Windows.Forms.Timer
    Friend WithEvents tmrExplosion2 As System.Windows.Forms.Timer
    Friend WithEvents picFire1 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeRight6 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeRight5 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeLeft5 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeLeft6 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeUp5 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeUp6 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeDown6 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplodeDown5 As System.Windows.Forms.PictureBox
    Friend WithEvents picExplode2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBomb2 As System.Windows.Forms.PictureBox

End Class
