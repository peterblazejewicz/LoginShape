namespace LoginShape;

public class IndicatorTemplateSelector : DataTemplateSelector
{
    public required DataTemplate ActiveTemplate { get; set; }
    public required DataTemplate DefaultTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return item is bool and true ? ActiveTemplate : DefaultTemplate;
    }
}