Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EscuelaDataSet.matricula' Puede moverla o quitarla según sea necesario.
        Me.MatriculasTableAdapter.Fill(Me.EscuelaDataSet.matricula)
        'TODO: esta línea de código carga datos en la tabla 'EscuelaDataSet.asignaturas' Puede moverla o quitarla según sea necesario.
        Me.AsignaturasTableAdapter.Fill(Me.EscuelaDataSet.asignaturas)
        'TODO: esta línea de código carga datos en la tabla 'EscuelaDataSet.alumnos' Puede moverla o quitarla según sea necesario.
        Me.AlumnosTableAdapter.Fill(Me.EscuelaDataSet.alumnos)
    End Sub

    Private Sub AlumnosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AlumnosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlumnosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EscuelaDataSet)
    End Sub

    Private Sub AsignaturasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AsignaturasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AsignaturasBindingSource.EndEdit()
        Me.AsignaturasTableAdapter.Update(Me.EscuelaDataSet)
        'Me.TableAdapterManager.UpdateAll(Me.EscuelaDataSet)
    End Sub

    Private Sub MatriculasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MatriculasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MatriculasBindingSource.EndEdit()
        Me.MatriculasTableAdapter.Update(Me.EscuelaDataSet)
    End Sub

End Class
