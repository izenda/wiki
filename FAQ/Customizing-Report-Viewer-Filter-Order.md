##How do I customize the report viewer filter order?

Currently there is no API way to arrange the filters. They, by default, are in the selected order.

The easiest way for such customization is to change:  

`RefreshFilters(returnObj)`

function in the Resources\js\ReportViewerFilters.js file.

The hook is here:

`var filterContent = GetFilterContent(returnObj.Filters, index, divsId, hasFilterLogic, false);`
`htmlFilters.find('.filtersContent').append(filterContent);`

filterContent is a filter control, htmlFilters.find('.filtersContent') is a holder for all filters.

You can generate controls for all filters, put them in some additional elements (for example put 'Send Start Date' and 'Send End Date' filters in a `<div>` so these filters will always be positioned together) and only then put everything in the '.filtersContent' element.

There is no one solution that can be used in all cases so you need to create logic that will satisfy your particular needs.
