Module Module1

    Sub Main(args As String())
        If args.Count >= 1 Then
            Dim inputFile As String = args(0)

            If IO.File.Exists(inputFile) = False Then
                Console.WriteLine($"No file under the name of '{inputFile}' found!")
            Else
                Dim outputFile As String = IO.Path.GetDirectoryName(inputFile) + "/" + IO.Path.GetFileNameWithoutExtension(inputFile) + ".min" + IO.Path.GetExtension(inputFile)
                Dim fReader = New IO.StreamReader(inputFile)
                Dim minified As String = ""
                Dim regex = New Text.RegularExpressions.Regex("\s")

                minified = regex.Replace(fReader.ReadToEnd, "")
                fReader.Close()

                Dim fWriter = New IO.StreamWriter(outputFile, False)
                fWriter.Write(minified)
                fWriter.Close()
            End If
        End If
    End Sub

End Module
