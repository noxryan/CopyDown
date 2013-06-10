Imports System

Class GuidList
    Private Sub New()
    End Sub

    Public Const guidCopyDownPkgString As String = "cd470a91-4513-4453-9b81-62dcf22c6e2c"
    Public Const guidCopyDownCmdSetString As String = "cbd6f49b-ef27-4253-ab44-12e8254a4064"

    Public Shared ReadOnly guidCopyDownCmdSet As New Guid(guidCopyDownCmdSetString)
End Class