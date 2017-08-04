using Core;
using Core.Events;
using SuanKeMeng.Models;
using System;
using System.Threading.Tasks;

namespace SuanKeMeng.Services
{
    public class SectorHandler : ModelEventHandler
    {
        protected override void InitializeComponents()
        {
            AddEventListener<Create<Sector>>(OnCreate);
            AddEventListener<Update<Sector>>(OnUpdate);
            AddEventListener<Delete<Sector>>(OnDelete);
            AddEventListener<Select<Sector>>(OnSelect);
        }
        protected virtual async Task<Create<Sector>> OnCreate(Create<Sector> eventData,
            CallNext<Create<Sector>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.CreateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Update<Sector>> OnUpdate(Update<Sector> eventData,
           CallNext<Update<Sector>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.UpdateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Delete<Sector>> OnDelete(Delete<Sector> eventData,
            CallNext<Delete<Sector>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.DeleteAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Select<Sector>> OnSelect(Select<Sector> eventData,
            CallNext<Select<Sector>> callnext)
        {
            var query = eventData.Query;

            if (query == null)
                throw new ArgumentNullException("query");

            eventData.ReturnValue = await DataService.SelectAsync(query);

            return await callnext(eventData);
        }

    }

}
