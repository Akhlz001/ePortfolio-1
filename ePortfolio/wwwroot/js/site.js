// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

tinymce.init(
{
    selector: 'textarea',
    toolbar: 'forecolor, backcolor, fontselect, fontsizeselect, bullist, numlist',
    font_formats: 'Arial=arial,helvetica,sans-serif;Courier New=courier new,courier,monospace;AkrutiKndPadmini=Akpdmi-n',
    min_height: 300,
    plugins: "textcolor,colorpickerlists,table,advlist",
    table_default_attributes:
    {
        'border': 1
    },
    table_default_styles: {
        'border-collapsed': 'collapse',
        'width': '100%'
    },
    table_responsive_width: true
});
