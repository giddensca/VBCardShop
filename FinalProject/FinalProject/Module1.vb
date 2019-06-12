Module Module1
    Public dblPrice As Double = 0.0
    Public dblTotalPrice As Double = 0.0
    Public dblShip As Double = 0.0
    Public Function deckSelected(ByVal DeckChoosen As String) As Double
        Dim dblDeckPrice As Double
        'Add deck to list box and update the price of the cart
        If (DeckChoosen = "Abzan") Then
            dblDeckPrice = 2043.0
        ElseIf (DeckChoosen = "Affinity") Then
            dblDeckPrice = 925.0
        ElseIf (DeckChoosen = "Burn") Then
            dblDeckPrice = 762.0
        ElseIf (DeckChoosen = "Devoted Company") Then
            dblDeckPrice = 1005.0
        ElseIf (DeckChoosen = "Dredge") Then
            dblDeckPrice = 699.0
        ElseIf (DeckChoosen = "Eldrazi Tron") Then
            dblDeckPrice = 840.0
        ElseIf (DeckChoosen = "Five-Color Humans") Then
            dblDeckPrice = 1411.0
        ElseIf (DeckChoosen = "Green Tron") Then
            dblDeckPrice = 769.0
        ElseIf (DeckChoosen = "Grixis Control") Then
            dblDeckPrice = 1768.0
        ElseIf (DeckChoosen = "Jeskai Control") Then
            dblDeckPrice = 1427.0
        ElseIf (DeckChoosen = "Storm") Then
            dblDeckPrice = 360.0
        ElseIf (DeckChoosen = "Titan Shift") Then
            dblDeckPrice = 698.0
        ElseIf (DeckChoosen = "Traverse Shadow") Then
            dblDeckPrice = 1370.0
        ElseIf (DeckChoosen = "Mardu Pyromancer") Then
            dblDeckPrice = 1062.0
        ElseIf (DeckChoosen = "White/Blue Control") Then
            dblDeckPrice = 975.0
        ElseIf (DeckChoosen = frmEnterDeck.txtDeckName.Text) Then
            dblDeckPrice = frmEnterDeck.txtPrice.Text
        End If
        'Return Deck Price
        Return (dblDeckPrice)
    End Function
    Public Sub updateCart(ByVal deckName As String)
        'add to list box on startup form
        frmMain.lstCart.Items.Add(deckName)
        'Update Price Label
        dblPrice = dblPrice + deckSelected(deckName)
        frmMain.lblSub.Text = dblPrice.ToString("c2")
        'Shipping Update
        If dblPrice < 2000 Then
            dblShip = 50.0
            frmMain.lblShipping.Text = dblShip.ToString("c2")
        ElseIf dblPrice > 2000 Then
            frmMain.lblShipping.Text = "Free!"
        End If
        dblTotalPrice = (dblPrice + dblShip)
        frmMain.lblTotal.Text = dblTotalPrice.ToString("c2")
    End Sub
End Module
