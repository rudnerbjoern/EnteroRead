Namespace My

    'The following events are available for MyApplication
    '
    'Startup: Raised when the application starts, before the startup form is created.
    'Shutdown: Raised after all application forms are closed.  This event is not raised if the application is terminating abnormally.
    'UnhandledException: Raised if the application encounters an unhandled exception.
    'StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    'NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    Class MyApplication

        Public Data As BioCodes


        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            Dim path As System.String
            path = IO.Path.Combine(My.Application.Info.DirectoryPath, "BioCodes.xml")

            Data = BioCodes.Load(path)

            If Data Is Nothing Then
                Data = New BioCodes
                Data.Add(New Code("99999", "name", "aTypical", "Confirm"))
                For i1 As System.Int32 = 0 To 3
                    If i1 = 1 Then GoTo NextI

                    For i2 As System.Int32 = 0 To 7

                        For i3 As System.Int32 = 0 To 7

                            For i4 As System.Int32 = 0 To 7

                                For i5 As System.Int32 = 0 To 7

                                    Dim tag As System.String

                                    tag = String.Format("{0}{1}{2}{3}{4}", i1, i2, i3, i4, i5)

                                    Dim name As System.String
                                    name = "Keim: " & tag

                                    Data.Add(New Code(tag, name, "NONE", String.Empty))



                                Next

                            Next

                        Next

                    Next


NextI:
                Next

                BioCodes.Save(path, Data)
            End If


        End Sub
    End Class

End Namespace
