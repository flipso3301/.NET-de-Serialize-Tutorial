Imports ExampleSerializer.Model
Imports Newtonsoft.Json

Public Class Deserializer
    
    Public Shared Function DeserializeJson(sJson as String ) As Example
        
        Return JsonConvert.DeserializeObject(Of Example)(sJson)
    
    End Function 

End Class
