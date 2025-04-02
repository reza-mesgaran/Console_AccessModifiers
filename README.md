# 🔒 C# Access Modifiers

A quick reference guide for access modifiers in C#.

## 📋 Index
- [A. Public](#a-public)
- [B. Private](#b-private)
- [C. Protected](#c-protected)
- [D. Internal](#d-internal)
- [E. Protected Internal](#e-protected-internal)
- [F. Private Protected](#f-private-protected)
- [Best Practices](#best-practices)

## A. Public:

- **Accessibility:** No restrictions
- **Access from:** Any code in the same assembly or another assembly that references it
- **Usage:** Public APIs, interfaces, and functionality meant to be used by external code

## B. Private:

- **Accessibility:** Most restrictive
- **Access from:** Only within the same class or struct
- **Usage:** Implementation details that should be hidden from other classes

## C. Protected:

- **Accessibility:** Limited to inheritance hierarchy
- **Access from:** The containing class and types derived from it
- **Usage:** Members that should be available to derived classes but hidden from external code

## D. Internal:

- **Accessibility:** Limited to the current assembly
- **Access from:** Any code in the same assembly, but not from other assemblies
- **Usage:** Classes and members that should be available throughout your application but not exposed externally

## E. Protected Internal:

- **Accessibility:** Combination of protected and internal
- **Access from:** Any code in the same assembly OR derived classes (even in other assemblies)
- **Usage:** Members that need to be accessed both within the assembly and by derived types

## F. Private Protected: 

- **Accessibility:** Added in C# 7.2
- **Access from:** Derived classes, but only within the same assembly
- **Usage:** Members that should only be accessible to derived classes within the same assembly

## Best Practices 🥇

- Use the most restrictive access level possible 
- Public members should be carefully designed as they become part of your API contract
- Prefer private fields with public properties for controlled access
- Consider using internal for components that should only be used within your assembly
- Use protected only when derived classes genuinely need access
