Imports ExampleSerializer.Model
Imports Newtonsoft.Json

Public Class Serializer
    
    Public Shared Function Serialize(oExample as Example) As String
        
        Return JsonConvert.SerializeObject(oExample, Formatting.Indented)
    
    End Function 

End Class
