Imports System.Collections.ObjectModel
Namespace My

    Partial Friend Class MyApplication
        Protected Overrides Function OnInitialize(ByVal commandLineArgs As ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 5000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function
    End Class

End Namespace