function CustomTable()
{
    this.TableId = '#tbDados',
    this.ActionUrl = '',
    this.Actions = '',
    this.TranslateUrl = '/Administrator/plugins/datatables/dataTableTranslate_pt-PT.txt',
    this.FilterMessage = 'Digite para filtrar',
    this.Columns = [],
    this.ColumnDefs = [],
    this.UseFilter = true,
    this.Paginate = true;
    this.PaginationInfo = true,
    this.CustomParameters = [],//[{'name' : '', 'element':$()}]
    this.OnCompletedAjaxLoad = function (e, settings, json, xhr) { },
    this.OnRenderComplete = function () { },
    this.Order = [[0, "asc"]]
    this.DrawCallback = undefined,
    this.Bind = function () {
        var ts = this;
        $(ts.TableId).DataTable().destroy();
        $(ts.TableId)
             .on('preXhr.dt', function (e, settings, data)
             {
                 if (data.length == -1) // Quando desliga a paginação
                 {
                     data.length = 999;
                 }
             })
            .on('xhr.dt', ts.OnCompletedAjaxLoad).dataTable({
            "serverSide": true,
            "language": ts.TranslateUrl,
            "processing": true,
            "autoWidth": false,
            "responsive": true,
            "bPaginate": ts.Paginate,
            "drawCallback": ts.DrawCallback,
            "bInfo" : ts.PaginationInfo,
            "columnDefs": ts.ColumnDefs,
            "bFilter": ts.UseFilter,
            "ajax": {
                "url": ts.ActionUrl,
                "data": function (d)
                {
                    $.each(ts.CustomParameters, function (index, obj)
                    {
                        d[obj.name] = obj.element.val();
                    });
                }
            },
            "columns": ts.Columns,
            //"order": ts.Order
        });
        
        $(ts.TableId).on('draw.dt', function () {
            var filter = ts.TableId + '_filter';
            var length = ts.TableId + '_length';
            
            $(filter).find('input')
                .addClass('form-control')
                .addClass('input-rounded')
                .addClass('ml-sm')
                .attr('placeholder', ts.FilterMessage)
                .css('height', '30px')
                .css('width', '240px');

            $(length)//ajusta length column
                .closest('.col-sm-6')
                .removeClass('col-sm-6')
                .addClass('col-sm-2 col-2');

            $(filter)//ajusta input column
                .closest('.col-sm-6')
                .removeClass('col-sm-6')
                .addClass('col-sm-10 col-10 d-none d-sm-table-cell');


            $(length).find('select').addClass('form-control').addClass('input-sm');
            $('.paginate_button').removeClass('paginate_button');
            ts.OnRenderComplete();

        });

    },
    this.Refresh = function () {
        $(this.TableId).dataTable().fnDraw(false);
    }
    this.Reload = function ()
    {
        $(this.TableId).DataTable().ajax.reload();
    }
}

function Details(url, code)
{
    var urlFull = url + "/" + code;

    $.get(urlFull, function (data) {
        $('#dvDetails').html(data);
    });
}

function Delete(url, code, area, controller, action)
{
    $.get(url, { 'code': code, 'area': area, 'controller': controller, 'action': action, 'title': 'Confirmação', 'question': 'Deseja realmente excluir este registro?' }, function (data) {
        $('#dvConfirm').html(data);
    });
}