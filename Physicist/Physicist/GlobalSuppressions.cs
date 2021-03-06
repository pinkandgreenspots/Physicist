// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1014:MarkAssembliesWithClsCompliant", Justification = "Monogame is NOT CLS compliant")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Not concerned with assembly security keys")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", Justification = "NPC is an Acronym", MessageId = "NPCs", Scope = "namespace", Target = "Physicist.Actors.NPCs")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Justification = "Monogame Generated", Scope = "member", Target = "Physicist.MainGame.#graphics")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Justification = "It's just a very large switch statement", Scope = "member", Target = "Physicist.Actors.BodyInfo.#XmlSerialize()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline", Justification = "Dean Says it's ok", Scope = "member", Target = "Physicist.Controls.MapLoader.#.cctor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Physics Engine tracks and disposes objects", Scope = "member", Target = "Physicist.Events.ProximityTrigger.#.ctor(System.Single,Microsoft.Xna.Framework.Vector2)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Justification = "Physics Engine tracks and disposes objects", Scope = "member", Target = "Physicist.Events.ProximityTrigger.#XmlDeserialize(System.Xml.Linq.XElement)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Justification = "It's ok since we don't do any initialization within the constructor", Scope = "member", Target = "Physicist.Events.ProximityTrigger.#.ctor(System.Xml.Linq.XElement)")]
