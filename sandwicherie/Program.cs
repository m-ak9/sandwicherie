using sandwicherie.adapters.primary;using sandwicherie.adapters.secondary;using sandwicherie.application_core;

// Configuration
FakeSandwichRepository fakeSandwichRepository = new FakeSandwichRepository();
BillingGenerator billingGenerator = new BillingGenerator();
DefaultOrderService defaultOrderService = new DefaultOrderService(fakeSandwichRepository, billingGenerator);
CLI cli = new CLI(defaultOrderService);

// Start
cli.MakeOrder();