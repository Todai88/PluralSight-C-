Imports System.Text
Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class StringExtensionsShould

    <TestMethod()> Public Sub ReturnDemo4_GivenStringDemoAnd4_WhenTestingFormatWith()

        Dim expected As String = "Demo 4"
        Dim actual As String = "Demo {0}".FormatWith(4)

        Assert.AreEqual(expected, actual)
    End Sub

End Class