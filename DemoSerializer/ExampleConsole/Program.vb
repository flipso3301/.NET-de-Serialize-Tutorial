Imports System
Imports ExampleSerializer
Imports ExampleSerializer.Model


Module Program
    Sub Main(args As String())
        Console.WriteLine("=====Welcome to (de) Serirializer demo=====")

        'Deserialize Example
        Dim oExample as Example = Deserializer.DeserializeJson("{'employees': [
                                                                {  'firstName':'John' , 'lastName':'Doe' }, 
                                                                {  'firstName':'Anna' , 'lastName':'Smith' }, 
                                                                { 'firstName': 'Peter' ,  'lastName': 'Jones ' }]}")
        
        Console.WriteLine("---Printing deserialized employees---")
        For Each oEmployee As Employee In oExample.employees
            ' Log first name and Last name to Console
            Console.WriteLine(oEmployee.firstName + " " + oEmployee.lastName)  
        Next      
        Console.WriteLine("-------------------------------------")

        'Define/Declare new Employee
        Dim oNewEmployee As Employee = New Employee With {.firstName = "James", .lastName = "Newton-King"}

        'Define/Declare new List of Employee
        Dim lstEmployees As new List(Of Employee) 
        lstEmployees.AddRange(oExample.employees)
        lstEmployees.Add(oNewEmployee)

        'Define/Declare new Example and lstEmployees
        Dim oNewExample As new Example With {.employees = lstEmployees.ToArray()}
        
        'Serialize NewExample
        Dim sNewJson As String = Serializer.Serialize(oNewExample)
        
        Console.WriteLine("----Printing serialized employees----")
        Console.WriteLine(sNewJson)
        Console.WriteLine("-------------------------------------")

        Console.WriteLine("===========================================")
    End Sub
End Module
