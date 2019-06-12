Imports System.IO
Public Class frmMain
    Dim readFile As StreamReader
    Dim writeFile As StreamWriter
    Dim intIndex As Integer = -1
    Dim intArray As Integer = 4

    Private Sub btnBuyDecks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuyDecks.Click
        'Open Deck Purchase
        frmDeckBuying.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        'Close Program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Empty all of cart and update prices
        lstCart.Items.Clear()
        lblShipping.Text = "$0"
        lblSub.Text = "$0"
        lblTotal.Text = "$0"

    End Sub

    Private Sub btnCheckout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckout.Click
        'Check out information then redirect to page for actual purchase
        MsgBox("You're total is " & dblTotalPrice.ToString("c2") & ". Hope you enjoyed shopping today and found what you need", MsgBoxStyle.OkOnly)
        If lstCart.Items.Contains("Abzan") Then
            System.Diagnostics.Process.Start("https://store.tcgplayer.com/massentry?partner=MTGGLDFSH&c=4%20Liliana%20of%20the%20Veil||1%20Liliana,%20the%20Last%20Hope||2%20Grim%20Flayer||2%20Scavenging%20Ooze||4%20Tarmogoyf||4%20Dark%20Confidant||1%20Tireless%20Tracker||2%20Maelstrom%20Pulse||4%20Inquisition%20of%20Kozilek||3%20Lingering%20Souls||2%20Thoughtseize||4%20Fatal%20Push||2%20Abrupt%20Decay||2%20Nihil%20Spellbomb||2%20Overgrown%20Tomb||1%20Windswept%20Heath||1%20Godless%20Shrine||2%20Treetop%20Village||2%20Blooming%20Marsh||1%20Twilight%20Mire||4%20Marsh%20Flats||4%20Verdant%20Catacombs||2%20Forest||2%20Swamp||1%20Shambling%20Vent||1%20Temple%20Garden||1%20Tireless%20Tracker||2%20Damnation||1%20Grafdigger%27s%20Cage||3%20Collective%20Brutality||1%20Engineered%20Explosives||3%20Stony%20Silence||1%20Duress||3%20Fulminator%20Mage||")
        End If
        If lstCart.Items.Contains("Affinity") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=4%20Arcbound%20Ravager||1%20Etched%20Champion||3%20Master%20of%20Etherium||3%20Memnite||4%20Ornithopter||4%20Signal%20Pest||4%20Steel%20Overseer||4%20Vault%20Skirge||4%20Darksteel%20Citadel||1%20Mountain||4%20Blinkmoth%20Nexus||4%20Inkmoth%20Nexus||4%20Spire%20of%20Industry||4%20Cranial%20Plating||4%20Springleaf%20Drum||4%20Galvanic%20Blast||4%20Mox%20Opal||1%20Grafdigger%27s%20Cage||3%20Etched%20Champion||2%20Ghirapur%20Aether%20Grid||2%20Rest%20in%20Peace||1%20Rule%20of%20Law||2%20Dispatch||2%20Spell%20Pierce||2%20Wear||")
        End If
        If lstCart.Items.Contains("Burn") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=4%20Goblin%20Guide||4%20Monastery%20Swiftspear||4%20Eidolon%20of%20the%20Great%20Revel||3%20Mountain||3%20Arid%20Mesa||3%20Bloodstained%20Mire||4%20Inspiring%20Vantage||2%20Sacred%20Foundry||1%20Scalding%20Tarn||1%20Stomping%20Ground||3%20Wooded%20Foothills||2%20Shrine%20of%20Burning%20Rage||4%20Boros%20Charm||4%20Lightning%20Bolt||4%20Lightning%20Helix||3%20Searing%20Blaze||3%20Skullcrack||4%20Lava%20Spike||4%20Rift%20Bolt||3%20Relic%20of%20Progenitus||2%20Kor%20Firewalker||4%20Destructive%20Revelry||2%20Path%20to%20Exile||1%20Searing%20Blaze||2%20Searing%20Blood||1%20Skullcrack||")
        End If
        If lstCart.Items.Contains("Devoted Company") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=1%20Walking%20Ballista||4%20Birds%20of%20Paradise||4%20Devoted%20Druid||2%20Duskwatch%20Recruiter||3%20Eternal%20Witness||4%20Kitchen%20Finks||2%20Noble%20Hierarch||1%20Scavenging%20Ooze||1%20Viscera%20Seer||4%20Vizier%20of%20Remedies||3%20Forest||1%20Plains||2%20Gavony%20Township||1%20Godless%20Shrine||2%20Horizon%20Canopy||2%20Overgrown%20Tomb||2%20Temple%20Garden||4%20Verdant%20Catacombs||4%20Windswept%20Heath||4%20Chord%20of%20Calling||4%20Collected%20Company||2%20Tireless%20Tracker||2%20Path%20to%20Exile||1%20Rhonas%20the%20Indomitable||1%20Eidolon%20of%20Rhetoric||1%20Path%20to%20Exile||1%20Kataki,%20War%27s%20Wage||1%20Linvala,%20Keeper%20of%20Silence||4%20Tidehollow%20Sculler||1%20Burrenton%20Forge-Tender||1%20Pharika,%20God%20of%20Affliction||1%20Orzhov%20Pontiff||1%20Qasali%20Pridemage||2%20Abrupt%20Decay||1%20Mirran%20Crusader||")
        End If
        If lstCart.Items.Contains("Dredge") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=4%20Bloodghast||3%20Golgari%20Thug||1%20Haunted%20Dead||4%20Insolent%20Neonate||4%20Narcomoeba||4%20Prized%20Amalgam||4%20Stinkweed%20Imp||2%20Mountain||3%20Arid%20Mesa||2%20Blackcleave%20Cliffs||1%20Blood%20Crypt||4%20Bloodstained%20Mire||3%20Copperline%20Gorge||2%20Dakmor%20Salvage||2%20Gemstone%20Mine||1%20Ghost%20Quarter||2%20Stomping%20Ground||4%20Cathartic%20Reunion||3%20Conflagrate||4%20Faithless%20Looting||3%20Life%20from%20the%20Loam||2%20Abrupt%20Decay||2%20Ancient%20Grudge||1%20Darkblast||2%20Lightning%20Axe||2%20Ravenous%20Trap||3%20Collective%20Brutality||3%20Thoughtseize||")
        End If
        If lstCart.Items.Contains("Eldrazi Tron") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=4%20Walking%20Ballista||1%20Wurmcoil%20Engine||2%20Endbringer||4%20Matter%20Reshaper||4%20Reality%20Smasher||4%20Thought-Knot%20Seer||1%20Ulamog,%20the%20Ceaseless%20Hunger||2%20Karn%20Liberated||3%20Wastes||2%20Cavern%20of%20Souls||4%20Eldrazi%20Temple||1%20Ghost%20Quarter||1%20Sanctum%20of%20Ugin||1%20Sea%20Gate%20Wreckage||4%20Urza%27s%20Mine||4%20Urza%27s%20Power%20Plant||4%20Urza%27s%20Tower||4%20Chalice%20of%20the%20Void||4%20Expedition%20Map||1%20Mind%20Stone||1%20Relic%20of%20Progenitus||2%20Dismember||2%20All%20Is%20Dust||1%20Basilisk%20Collar||2%20Grafdigger%27s%20Cage||3%20Ratchet%20Bomb||2%20Relic%20of%20Progenitus||2%20Sorcerous%20Spyglass||2%20Hangarback%20Walker||3%20Warping%20Wail||")
        End If
        If lstCart.Items.Contains("Five-Color Humans") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=4%20Champion%20of%20the%20Parish||1%20Kessig%20Malcontents||4%20Kitesail%20Freebooter||4%20Mantis%20Rider||4%20Meddling%20Mage||4%20Noble%20Hierarch||4%20Phantasmal%20Image||4%20Reflector%20Mage||4%20Thalia%27s%20Lieutenant||4%20Thalia,%20Guardian%20of%20Thraben||1%20Island||1%20Plains||1%20Ancient%20Ziggurat||1%20Botanical%20Sanctum||4%20Cavern%20of%20Souls||4%20Horizon%20Canopy||1%20Razorverge%20Thicket||2%20Seachrome%20Coast||4%20Unclaimed%20Territory||4%20Aether%20Vial||2%20Izzet%20Staticaster||1%20Kessig%20Malcontents||2%20Sin%20Collector||3%20Vithian%20Renegades||1%20Xathrid%20Necromancer||2%20Dismember||1%20Gut%20Shot||2%20Kambal,%20Consul%20of%20Allocation||1%20Kataki,%20War%27s%20Wage||")
        End If
        If lstCart.Items.Contains("Green Tron") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=3%20Wurmcoil%20Engine||1%20World%20Breaker||2%20Ulamog,%20the%20Ceaseless%20Hunger||4%20Karn%20Liberated||2%20Ugin,%20the%20Spirit%20Dragon||2%20Forest||4%20Grove%20of%20the%20Burnwillows||1%20Sanctum%20of%20Ugin||4%20Urza%27s%20Mine||4%20Urza%27s%20Power%20Plant||4%20Urza%27s%20Tower||4%20Chromatic%20Sphere||4%20Chromatic%20Star||4%20Expedition%20Map||3%20Oblivion%20Stone||2%20Pithing%20Needle||2%20Kozilek%27s%20Return||2%20Nature%27s%20Claim||4%20Ancient%20Stirrings||4%20Sylvan%20Scrying||1%20Grafdigger%27s%20Cage||1%20Relic%20of%20Progenitus||2%20Torpor%20Orb||3%20Obstinate%20Baloth||1%20World%20Breaker||2%20Blood%20Sun||3%20Lightning%20Bolt||2%20Nature%27s%20Claim||")
        End If
        If lstCart.Items.Contains("Grixis Control") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=2%20Gurmag%20Angler||4%20Snapcaster%20Mage||2%20Tasigur,%20the%20Golden%20Fang||1%20Vendilion%20Clique||1%20Rise%20//%20Fall||4%20Serum%20Visions||1%20Thoughtseize||3%20Cryptic%20Command||3%20Kolaghan%27s%20Command||4%20Lightning%20Bolt||2%20Mana%20Leak||1%20Remand||2%20Spell%20Snare||4%20Terminate||4%20Thought%20Scour||1%20Blood%20Crypt||2%20Creeping%20Tar%20Pit||3%20Island||1%20Mountain||4%20Polluted%20Delta||4%20Scalding%20Tarn||2%20Steam%20Vents||2%20Sulfur%20Falls||1%20Swamp||2%20Watery%20Grave||1%20Vendilion%20Clique||1%20Rise%20//%20Fall||1%20Thoughtseize||2%20Anger%20of%20the%20Gods||2%20Dispel||3%20Fulminator%20Mage||1%20Grim%20Lavamancer||1%20Izzet%20Staticaster||1%20Keranos,%20God%20of%20Storms||2%20Nihil%20Spellbomb||")
        End If
        If lstCart.Items.Contains("Jeskai Control") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=4%20Snapcaster%20Mage||2%20Teferi,%20Hero%20of%20Dominaria||3%20Island||1%20Mountain||2%20Plains||4%20Celestial%20Colonnade||4%20Flooded%20Strand||1%20Glacial%20Fortress||2%20Hallowed%20Fountain||1%20Sacred%20Foundry||4%20Scalding%20Tarn||2%20Steam%20Vents||1%20Sulfur%20Falls||4%20Cryptic%20Command||2%20Electrolyze||3%20Lightning%20Bolt||3%20Lightning%20Helix||3%20Logic%20Knot||1%20Mana%20Leak||4%20Path%20to%20Exile||1%20Sphinx%27s%20Revelation||2%20Search%20for%20Azcanta||4%20Serum%20Visions||2%20Supreme%20Verdict||2%20Damping%20Sphere||1%20Engineered%20Explosives||1%20Dire%20Fleet%20Daredevil||1%20Izzet%20Staticaster||1%20Stony%20Silence||1%20Abrade||1%20Celestial%20Purge||1%20Disdainful%20Stroke||1%20Dispel||1%20Negate||1%20Settle%20the%20Wreckage||1%20Wear||1%20Vendilion%20Clique||1%20Elspeth,%20Sun%27s%20Champion||")
        End If
        If lstCart.Items.Contains("Storm") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=3%20Goblin%20Electromancer||4%20Baral,%20Chief%20of%20Compliance||2%20Island||1%20Mountain||1%20Snow-Covered%20Island||2%20Misty%20Rainforest||1%20Polluted%20Delta||4%20Scalding%20Tarn||4%20Spirebluff%20Canal||2%20Steam%20Vents||4%20Desperate%20Ritual||4%20Gifts%20Ungiven||4%20Manamorphose||1%20Noxious%20Revival||2%20Opt||4%20Pyretic%20Ritual||3%20Remand||1%20Repeal||3%20Grapeshot||2%20Past%20in%20Flames||4%20Serum%20Visions||4%20Sleight%20of%20Hand||2%20Blood%20Moon||1%20Dismember||2%20Dispel||1%20Echoing%20Truth||2%20Lightning%20Bolt||1%20Wipe%20Away||2%20Empty%20the%20Warrens||2%20Pieces%20of%20the%20Puzzle||2%20Shattering%20Spree||")
        End If
        If lstCart.Items.Contains("Titan Shift") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=2%20Obstinate%20Baloth||4%20Primeval%20Titan||4%20Sakura-Tribe%20Elder||2%20Forest||7%20Mountain||2%20Cinder%20Glade||4%20Stomping%20Ground||4%20Valakut,%20the%20Molten%20Pinnacle||3%20Windswept%20Heath||4%20Wooded%20Foothills||2%20Relic%20of%20Progenitus||2%20Khalni%20Heart%20Expedition||2%20Prismatic%20Omen||2%20Lightning%20Bolt||2%20Summoner%27s%20Pact||3%20Explore||3%20Farseek||4%20Scapeshift||4%20Search%20for%20Tomorrow||2%20Grafdigger%27s%20Cage||1%20Chameleon%20Colossus||1%20Reclamation%20Sage||2%20Tireless%20Tracker||2%20Beast%20Within||2%20Dismember||1%20Kozilek%27s%20Return||1%20Pulse%20of%20Murasa||2%20Anger%20of%20the%20Gods||1%20Shattering%20Spree||")
        End If
        If lstCart.Items.Contains("Traverse Shadow") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=4%20Death%27s%20Shadow||1%20Grim%20Flayer||4%20Street%20Wraith||4%20Tarmogoyf||2%20Liliana%20of%20the%20Veil||1%20Swamp||1%20Blood%20Crypt||4%20Bloodstained%20Mire||1%20Breeding%20Pool||2%20Overgrown%20Tomb||4%20Polluted%20Delta||4%20Verdant%20Catacombs||1%20Watery%20Grave||4%20Mishra%27s%20Bauble||2%20Abrupt%20Decay||1%20Dismember||3%20Fatal%20Push||3%20Stubborn%20Denial||2%20Temur%20Battle%20Rage||4%20Inquisition%20of%20Kozilek||4%20Thoughtseize||4%20Traverse%20the%20Ulvenwald||1%20Ranger%20of%20Eos||1%20Ancient%20Grudge||2%20Disdainful%20Stroke||1%20Fatal%20Push||2%20Kozilek%27s%20Return||1%20Stubborn%20Denial||1%20Temur%20Battle%20Rage||1%20Collective%20Brutality||3%20Lingering%20Souls||1%20Maelstrom%20Pulse||1%20Godless%20Shrine||")
        End If
        If lstCart.Items.Contains("Mardu Pyromancer") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=1%20Liliana%20of%20the%20Veil||4%20Young%20Pyromancer||4%20Bedlam%20Reveler||4%20Faithless%20Looting||1%20Dreadbore||2%20Collective%20Brutality||4%20Lingering%20Souls||4%20Inquisition%20of%20Kozilek||3%20Thoughtseize||4%20Lightning%20Bolt||2%20Fatal%20Push||1%20Terminate||1%20Manamorphose||3%20Kolaghan%27s%20Command||2%20Blood%20Moon||4%20Blackcleave%20Cliffs||2%20Swamp||3%20Mountain||1%20Sacred%20Foundry||2%20Blood%20Crypt||4%20Bloodstained%20Mire||4%20Marsh%20Flats||2%20Collective%20Brutality||1%20Liliana%20of%20the%20Veil||2%20Molten%20Rain||1%20Ghost%20Quarter||3%20Surgical%20Extraction||2%20Nihil%20Spellbomb||1%20Anger%20of%20the%20Gods||2%20Wear//tear||1%20Fulminator%20Mage||")
        End If
        If lstCart.Items.Contains("White/Blue Control") Then
            System.Diagnostics.Process.Start("http://store.tcgplayer.com/list/selectproductmagic.aspx?partner=MTGGLDFSH&c=1%20Elspeth,%20Sun%27s%20Champion||1%20Gideon%20Jura||1%20Jace,%20Architect%20of%20Thought||3%20Snapcaster%20Mage||1%20Vendilion%20Clique||4%20Ancestral%20Vision||4%20Serum%20Visions||3%20Supreme%20Verdict||1%20Blessed%20Alliance||2%20Condemn||3%20Cryptic%20Command||2%20Mana%20Leak||4%20Path%20to%20Exile||2%20Spell%20Snare||1%20Detention%20Sphere||4%20Spreading%20Seas||4%20Celestial%20Colonnade||4%20Flooded%20Strand||4%20Ghost%20Quarter||1%20Glacial%20Fortress||2%20Hallowed%20Fountain||5%20Island||3%20Plains||1%20Vendilion%20Clique||1%20Celestial%20Purge||1%20Disenchant||1%20Dispel||2%20Negate||2%20Rest%20in%20Peace||3%20Spell%20Queller||2%20Stony%20Silence||2%20Timely%20Reinforcements||")
        End If
    End Sub

    Private Sub btnDeckSim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeckSim.Click
        frmSims.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        frmLogin.Close()
        frmCreate.Close()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCheckout.Enabled = False
    End Sub

    Private Sub lblShipping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblShipping.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub lstCart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCart.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub lblSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSub.Click

    End Sub

    Private Sub lblTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub mnuFileClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileClear.Click
        lstCart.Items.Clear()
        lblShipping.Text = "$0"
        lblSub.Text = "$0"
        lblTotal.Text = "$0"
        dblShip = 0.0
        dblTotalPrice = 0.0
        dblPrice = 0.0
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub ClearCartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lstCart.Items.Clear()
        lblShipping.Text = "$0"
        lblSub.Text = "$0"
        lblTotal.Text = "$0"
        dblShip = 0
        dblTotalPrice = 0
        dblPrice = 0
    End Sub

    Private Sub ClearCartToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearCartToolStripMenuItem.Click
        lstCart.Items.Clear()
        lblShipping.Text = "$0"
        lblSub.Text = "$0"
        lblTotal.Text = "$0"
        dblShip = 0.0
        dblTotalPrice = 0.0
        dblPrice = 0.0
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub
End Class