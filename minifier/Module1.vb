Module Module1

    Sub Main(args As String())
        Dim inputFile As String
        If args.Count >= 1 Then
            inputFile = args(0)
        Else
            Console.Write("Please enter a valid target file: ")
            inputFile = Console.ReadLine()
        End If

        'Console.WriteLine("Path: " + IO.Path.GetFullPath(inputFile))
        'Console.ReadLine()
        If IO.File.Exists(inputFile) = False Then
            Console.WriteLine($"No file under the name of '{inputFile}' found!")
        Else
            Dim outputFile As String = inputFile.Insert(inputFile.LastIndexOf("."), ".min")
            Dim fReader = New IO.StreamReader(inputFile)
            Dim minified As String = ""
            Dim regex = New Text.RegularExpressions.Regex("\s")

            minified = regex.Replace(fReader.ReadToEnd, "")
            fReader.Close()

            Dim fWriter = New IO.StreamWriter(outputFile, False)
            fWriter.Write(minified)
            fWriter.Close()
        End If
    End Sub

End Module
