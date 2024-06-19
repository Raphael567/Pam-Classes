# Pam-Classes
repositório destinado as aulas de PAM

PARTE ESCRITA PRÉ-AVALIAÇÂO DE PAM:

1. PARA QUE SERVE O MVVM?

MVVM, que significa Model-View-ViewModel, é um padrão de arquitetura de software frequentemente utilizado no desenvolvimento de interfaces de usuário, especialmente em aplicações que seguem o paradigma de programação orientada a objetos. 

- Model: Representa os dados e a lógica de negócios da aplicação.
- ViewModel: Age como um intermediário entre a View e o Modelo. Ele contém lógica de apresentação que prepara os dados para serem exibidos pela View. 
- View: É a camada que representa a interface do usuário. 

________________________________________________________________

2. O QUE É O MVVM COMMUNITY TOOLKIT?

O MVVM Community Toolkit é uma biblioteca de código aberto desenvolvida pela comunidade para suportar o padrão MVVM (Model-View-ViewModel) em aplicações WPF (Windows Presentation Foundation), UWP (Universal Windows Platform), e Xamarin.Forms. Esta biblioteca fornece uma série de utilitários, controles e extensões que ajudam os desenvolvedores a implementar aplicações de forma mais eficiente e seguindo as melhores práticas do MVVM.

- Controles MVVM: Inclui controles específicos que são projetados para serem facilmente ligados a ViewModels, simplificando a ligação entre a camada de apresentação e a camada de lógica de negócios.

- Comandos e Behaviors: Oferece classes para facilitar a implementação de comandos e behaviors, permitindo que a lógica da interface do usuário seja encapsulada em ViewModel sem que a View precise manipular diretamente eventos.

- Utilitários de MVVM: Inclui utilitários como validadores de entrada, conversores de tipos de dados e classes de suporte para notificação de alterações (INotifyPropertyChanged), ajudando na implementação robusta e eficiente de ViewModels.

- Suporte a Async/Await: Fornece classes e métodos para facilitar o trabalho com operações assíncronas no contexto do MVVM, permitindo que chamadas de serviço e operações de E/S sejam tratadas de forma assíncrona sem bloquear a interface do usuário.

- Documentação e Exemplos: Acompanha documentação detalhada e exemplos de uso, ajudando os desenvolvedores a entender como integrar e utilizar os recursos oferecidos pelo toolkit em suas aplicações.

________________________________________________________________

3. PARA QUE SERVE O ARQUIVO APPSHELL? COMO ADICIONAR UMA VIEW PARA SER EXIBIDA NO LUGAR DA MAIN PAGE?

O arquivo AppShell é usado em aplicações Xamarin.Forms para definir a estrutura principal da aplicação, incluindo a navegação entre diferentes partes da interface do usuário. Ele atua como o contêiner principal onde as páginas (views) da aplicação são organizadas e navegadas.

Adicionar a view no lugar da main page:

Definir a página:

```
// NovaPagina.xaml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MinhaApp.Views.NovaPagina">
    <!-- Conteúdo da página -->
</ContentPage>
```

Registrar a página no AppShell:

```
// AppShell.xaml.cs
public partial class AppShell : Xamarin.Forms.Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(NovaPagina), typeof(NovaPagina));
    }
}
```

Navegar na nova página:

```
// Exemplo de navegação a partir de um botão ou evento
await Shell.Current.GoToAsync($"//{nameof(NovaPagina)}");
```

________________________________________________________________

4. O QUE É BINDING? EM QUE ARQUIVO CRIAMOS OS BINDINGS?

O Binding (ou ligação, em tradução literal) é um conceito central em frameworks de desenvolvimento de interfaces de usuário, como Xamarin.Forms, WPF (Windows Presentation Foundation), e outros. Ele permite a conexão dinâmica e automática entre os dados do modelo (Model) e a interface do usuário (View), garantindo que qualquer alteração nos dados seja refletida imediatamente na interface e vice-versa, sem a necessidade de intervenção manual.

Os Bindings são criados principalmente nos arquivos de definição da interface do usuário, que podem ser escritos em XAML ou diretamente em código.

```
<!-- Exemplo de Binding em XAML -->
<Label Text="{Binding Nome}" />
```
________________________________________________________________

5. O QUE É BINDING CONTEXT? ESCREVA COMO ASSOCIAMOS O BINDING CONTEXT A CLASSE VIEWMODEL.

O Binding Context é uma propriedade em estruturas de desenvolvimento de interfaces de usuário, como Xamarin.Forms e WPF, que permite associar um objeto de dados (geralmente uma classe ViewModel) a uma parte da interface do usuário (View). Essa associação permite que os elementos da interface sejam ligados dinamicamente aos dados da ViewModel, facilitando a exibição e a atualização automática das informações na interface conforme os dados mudam.

Definir uma ViewModel:

```
public class MinhaViewModel : INotifyPropertyChanged
{
    private string _nome;
    public string Nome
    {
        get { return _nome; }
        set
        {
            if (_nome != value)
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }
    }

    // Implementação do INotifyPropertyChanged omitida para brevidade
    public event PropertyChangedEventHandler PropertyChanged;
    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
```

Exemplo em XAML:

```
<ContentPage x:Class="MinhaApp.MinhaPagina"
             xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:viewModel="clr-namespace:MinhaApp.ViewModels"
             BindingContext="{Binding Source={StaticResource MinhaViewModel}}">
    <StackLayout>
        <Label Text="{Binding Nome}" />
        <!-- Outros controles vinculados -->
    </StackLayout>
</ContentPage>
```
________________________________________________________________

6. PARA QUE SERVE A VIEWMODEL?

A ViewModel desempenha várias funções importantes que melhoram a estrutura, a manutenibilidade e a testabilidade de aplicações de software. Ela melhora a organização do código, facilita a manutenção, promove a reutilização e melhora a testabilidade das aplicações, tornando-se uma peça essencial na arquitetura de software moderna voltada para interfaces de usuário interativas e dinâmicas.

________________________________________________________________

7. O QUE QUER DIZER QUE UM ATRIBUTO É UMA PROPRIEDADE OBSERVÁVEL? [Observable Propriety]?

Uma propriedade observável (Observable Property) refere-se a uma propriedade de um objeto que implementa um padrão de notificação de alterações para que outras partes do sistema possam ser informadas quando o valor dessa propriedade é modificado. Esse conceito é especialmente relevante em frameworks de desenvolvimento de interfaces de usuário (UI) e padrões arquiteturais como MVVM (Model-View-ViewModel).
