using Core;
using Core.Events;
using SuanKeMeng.Models;
using System;
using System.Threading.Tasks;

namespace SuanKeMeng.Services
{

    public class TopicHandler : ModelEventHandler
    {
        protected override void InitializeComponents()
        {
            AddEventListener<Create<Topic>>(OnCreate);
            AddEventListener<Update<Topic>>(OnUpdate);
            AddEventListener<Delete<Topic>>(OnDelete);
            AddEventListener<Select<Topic>>(OnSelect);
        }
        protected virtual async Task<Create<Topic>> OnCreate(Create<Topic> eventData,
            CallNext<Create<Topic>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.CreateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Update<Topic>> OnUpdate(Update<Topic> eventData,
           CallNext<Update<Topic>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.UpdateAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Delete<Topic>> OnDelete(Delete<Topic> eventData,
            CallNext<Delete<Topic>> callnext)
        {
            var model = eventData.Model;

            if (model == null)
                throw new ArgumentNullException("model");

            eventData.ReturnValue = await DataService.DeleteAsync(model);

            return await callnext(eventData);
        }

        protected virtual async Task<Select<Topic>> OnSelect(Select<Topic> eventData,
            CallNext<Select<Topic>> callnext)
        {
            var query = eventData.Query;

            if (query == null)
                throw new ArgumentNullException("query");

            eventData.ReturnValue = await DataService.SelectAsync(query);

            return await callnext(eventData);
        }

    }

}
