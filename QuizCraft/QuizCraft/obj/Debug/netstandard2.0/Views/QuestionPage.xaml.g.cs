//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("QuizCraft.Views.QuestionPage.xaml", "Views/QuestionPage.xaml", typeof(global::QuizCraft.Views.QuestionPage))]

namespace QuizCraft.Views {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Views\\QuestionPage.xaml")]
    public partial class QuestionPage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Plugin.InputKit.Shared.Controls.SelectionView CurrentResponse;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::SkiaRate.RatingView Rate;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Button ButtonValider;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(QuestionPage));
            CurrentResponse = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Plugin.InputKit.Shared.Controls.SelectionView>(this, "CurrentResponse");
            Rate = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::SkiaRate.RatingView>(this, "Rate");
            ButtonValider = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Button>(this, "ButtonValider");
        }
    }
}